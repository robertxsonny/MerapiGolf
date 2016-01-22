using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MerapiGolfLogistik.Models;
using System.IO;
using System.Globalization;
using OfficeOpenXml;

namespace MerapiGolfLogistik
{
    public partial class LaporanGudang : Form
    {
        private MerapiGolfLogistikEntities dbContent = new MerapiGolfLogistikEntities();
        private Guid selectedCategory = Guid.Empty;
        private Classes.LaporanGudang report;
        public LaporanGudang()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.ActiveControl = this.reportView;
            this.StartPosition = FormStartPosition.CenterScreen;
            RefreshView();
        }

        private void SelectCategory()
        {
            PilihKategori pilihform = new PilihKategori();
            var dlgmsg = pilihform.ShowDialog();
            if (dlgmsg == DialogResult.OK)
            {
                this.selectedCategory = pilihform.selectedId;
                var category = dbContent.mg_kategori.Where(p => p.id == this.selectedCategory).Single();
                kategoriTb.Text = category.nama_kategori;
                RefreshView();
            }
        }

        private void RefreshView()
        {
            dbContent = new MerapiGolfLogistikEntities();
            //List<LaporanBarangExtended> result = new List<LaporanBarangExtended>();


            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now;
            DateTime.TryParse(dariTanggalTb.Text, out start);
            DateTime.TryParse(sampaiTanggalTb.Text, out end);
            report = Classes.LaporanGudang.GenerateLaporanGudang(start, end);

            //var reports = dbContent.LaporanGudangFilter(start, end).ToList().OrderBy(p => p.nama_kategori).ToList();
            //if (this.selectedCategory != Guid.Empty)
            //    reports = reports.Where(p => p.idkategori == this.selectedCategory).ToList();
            //if (reports.Count > 0)
            //{
            //    foreach (var report in reports)
            //    { 
            //        LaporanBarangExtended laporan = new LaporanBarangExtended();
            //        var barang = dbContent.mg_barang.Where(p => p.id == report.id).Single();
            //        var allpembelian = dbContent.mg_pembelian_item.Where(p => p.barang_id == barang.id).ToList();
            //        allpembelian.ForEach((p) =>
            //        {
            //            p.harga_satuan = p.harga_satuan * p.banyak_barang;
            //        });
            //        double saldoAwal = allpembelian.Sum(p => p.harga_satuan.Value);
            //        double stokAwal = allpembelian.Sum(p => p.banyak_barang.Value);
            //        laporan.saldoAwal = saldoAwal;
            //        laporan.stokAwal = stokAwal;
            //        laporan.id = report.id;
            //        laporan.idkategori = report.idkategori;
            //        laporan.jumlahhrgbeli = report.jumlahhrgbeli;
            //        laporan.jumlahhrgpakai = report.jumlahhrgpakai;
            //        laporan.nama_barang = report.nama_barang;
            //        laporan.nama_kategori = report.nama_kategori;
            //        laporan.saldo = report.saldo;
            //        laporan.satuan = report.satuan;
            //        laporan.stokkeluar = report.stokkeluar;
            //        laporan.stokmasuk = report.stokmasuk;
            //        laporan.stoksaldo = report.stoksaldo;
            //        result.Add(laporan);
            //    }

            //}

            reportView.DataSource = null;
            //reportView.DataSource = result;
            reportView.DataSource = report.Items;
            reportView.DefaultCellStyle.FormatProvider = new CultureInfo("id-ID");
        }

        private void PrintToExcel()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel File (*.xlsx)|*.xlsx";
            sfd.FileName = "Laporan Gudang " + dariTanggalTb.Value.ToString("ddMMyyyy", new CultureInfo("id-ID")) + " - " + sampaiTanggalTb.Value.ToString("ddMMyyyy", new CultureInfo("id-ID")) + ".xlsx";
            sfd.FilterIndex = 1;
            var result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    FileInfo file = new FileInfo(sfd.FileName);
                    if (file.Exists)
                    {
                        file.Delete();
                    }

                    using (ExcelPackage excelFile = new ExcelPackage())
                    {
                        ExcelWorksheet sheet1 = excelFile.Workbook.Worksheets.Add("Laporan Gudang");
                        
                        sheet1.Cells["B1"].Value = "PT MERAPI GOLF";
                        sheet1.Cells["B1:H1"].Merge = true;
                        sheet1.Cells["B2"].Value = "YOGYAKARTA";
                        sheet1.Cells["B2:H2"].Merge = true;


                        sheet1.Cells["B4"].Value = "LAPORAN PEMAKAIAN BARANG GUDANG";
                        sheet1.Cells["B4:H4"].Merge = true;
                        sheet1.Cells["B5"].Value = "PERIODE";
                        sheet1.Cells["B5:C5"].Merge = true;
                        sheet1.Cells["D5"].Value = ": " + report.Periode.ToUpper();
                        sheet1.Cells["D5:H5"].Merge = true;
                        sheet1.Cells["B6"].Value = "BAGIAN";
                        sheet1.Cells["B6:C6"].Merge = true;
                        sheet1.Cells["D6"].Value = ": PERAWATAN";
                        sheet1.Cells["D6:H6"].Merge = true;

                        ExcelRange range1 = sheet1.Cells["B1:H6"];
                        range1.Style.Font.Bold = true;

                        //sheet1.Cells["A4"].LoadFromCollection((List<LaporanBarangExtended>)reportView.DataSource, true);

                        sheet1.Cells["A8"].Value = "NO";
                        sheet1.Cells["A8:A9"].Merge = true;
                        sheet1.Cells["B8"].Value = "SUBSI";
                        sheet1.Cells["B8:B9"].Merge = true;
                        sheet1.Cells["C8"].Value = "TGL" + Environment.NewLine + "KELUAR";
                        sheet1.Cells["C8:C9"].Merge = true;
                        sheet1.Cells["D8"].Value = "URAIAN";
                        sheet1.Cells["D8:D9"].Merge = true;
                        sheet1.Cells["E8"].Value = "STOCK";
                        sheet1.Cells["E8:E9"].Merge = true;
                        sheet1.Cells["F8"].Value = "IN";
                        sheet1.Cells["F8:F9"].Merge = true;
                        sheet1.Cells["G8"].Value = "OUT";
                        sheet1.Cells["G8:G9"].Merge = true;
                        sheet1.Cells["H8"].Value = "HARGA";
                        sheet1.Cells["H9"].Value = "PER UNIT";
                        sheet1.Cells["I8"].Value = "JML HARGA";
                        sheet1.Cells["I8:J8"].Merge = true;
                        sheet1.Cells["I9"].Value = "BELI";
                        sheet1.Cells["J9"].Value = "PAKAI";
                        sheet1.Cells["K8"].Value = "SALDO";
                        sheet1.Cells["K8:L8"].Merge = true;
                        sheet1.Cells["K9"].Value = "UNIT";
                        sheet1.Cells["L9"].Value = "HARGA";

                        ExcelRange range2 = sheet1.Cells["A8:L9"];
                        range2.Style.Font.Bold = true;
                        range2.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        range2.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;

                        //for (int j = 2; j < reportView.ColumnCount; j++)
                        //{
                        //    sheet1.Cells[4, j - 1].Value = reportView.Columns[j].HeaderText;
                        //    for (int i = 0; i < reportView.RowCount; i++)
                        //    {
                        //        sheet1.Cells[i + 5, j - 1].Value = reportView[j, i].Value;
                        //    }
                        //    sheet1.Column(j - 1).AutoFit();
                        //}      

                        int no = 1;
                        int categoryCount = 0;
                        string categoryName = "";
                        double totalMasuk = 0;
                        double totalKeluar = 0;
                        foreach (Classes.LaporanGudangItem item in report.Items)
                        {
                            int rowNo = 11 + ((report.Items.IndexOf(item)*3) + 1) + categoryCount;
                            if (item.Kategori != categoryName)
                            {
                                categoryName = item.Kategori;
                                sheet1.Cells[rowNo, 4].Value = categoryName;
                                sheet1.Cells[rowNo, 4].Style.Font.Bold = true;
                                sheet1.Cells[rowNo, 4, rowNo, 12].Merge = true;
                                categoryCount++;
                                rowNo++;
                                no = 1;
                            }

                            sheet1.Cells[rowNo, 1].Value = no;
                            sheet1.Cells[rowNo, 2].Value = item.Subsi;
                            sheet1.Cells[rowNo, 4].Value = item.NamaBarang;
                            sheet1.Cells[rowNo, 5].Value = item.Stok.ToString("N", new CultureInfo("id-ID"));
                            sheet1.Cells[rowNo, 8].Value = item.HargaSatuan.ToString("N", new CultureInfo("id-ID"));
                            sheet1.Cells[rowNo, 11].Value = item.Stok.ToString("N", new CultureInfo("id-ID"));
                            sheet1.Cells[rowNo, 12].Value = item.HargaStok.ToString("N", new CultureInfo("id-ID"));
                            sheet1.Cells[rowNo + 1, 2].Value = item.Subsi;
                            sheet1.Cells[rowNo + 1, 3].Value = item.TanggalKeluar;
                            sheet1.Cells[rowNo + 1, 4].Value = item.NamaBarang;
                            sheet1.Cells[rowNo + 1, 5].Value = item.Stok.ToString("N", new CultureInfo("id-ID"));
                            sheet1.Cells[rowNo + 1, 6].Value = item.StokMasuk.ToString("N", new CultureInfo("id-ID"));
                            sheet1.Cells[rowNo + 1, 7].Value = item.StokKeluar.ToString("N", new CultureInfo("id-ID"));
                            sheet1.Cells[rowNo + 1, 8].Value = item.HargaSatuan.ToString("N", new CultureInfo("id-ID"));
                            sheet1.Cells[rowNo + 1, 9].Value = item.HargaMasuk.ToString("N", new CultureInfo("id-ID"));
                            sheet1.Cells[rowNo + 1, 10].Value = item.HargaKeluar.ToString("N", new CultureInfo("id-ID"));
                            sheet1.Cells[rowNo + 1, 11].Value = item.Saldo.ToString("N", new CultureInfo("id-ID"));
                            sheet1.Cells[rowNo + 1, 12].Value = item.HargaSaldo.ToString("N", new CultureInfo("id-ID"));
                            sheet1.Cells[rowNo, 5, rowNo + 1, 12].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;
                            totalMasuk += item.HargaMasuk;
                            totalKeluar += item.HargaKeluar;
                            no++;
                        }

                        for (int i = 1; i <= 12; i++)
                            sheet1.Column(i).AutoFit(5);

                        sheet1.Cells[((report.Items.Count) * 3) + categoryCount + 12, 4].Value = "JUMLAH";
                        sheet1.Cells[((report.Items.Count) * 3) + categoryCount + 12, 9].Value = totalMasuk.ToString("N", new CultureInfo("id-ID"));
                        sheet1.Cells[((report.Items.Count) * 3) + categoryCount + 12, 10].Value = totalKeluar.ToString("N", new CultureInfo("id-ID"));

                        ExcelRange range3 = sheet1.Cells[((report.Items.Count) * 3) + categoryCount + 12, 1, ((report.Items.Count) * 3) + categoryCount + 12, 11];
                        range3.Style.Font.Bold = true;
                        range3.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;

                        sheet1.Cells[8, 1, ((report.Items.Count) * 3) + categoryCount + 12, 12].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        sheet1.Cells[8, 1, ((report.Items.Count) * 3) + categoryCount + 12, 12].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        sheet1.Cells[8, 1, ((report.Items.Count) * 3) + categoryCount + 12, 12].Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        sheet1.Cells[8, 1, ((report.Items.Count) * 3) + categoryCount + 12, 12].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

                        excelFile.SaveAs(file);
                        //excelFile.File.Open(FileMode.Open);

                        MessageBox.Show("Berhasil menyimpan laporan ke dalam format Excel. Silakan lakukan pencetakan dari file Excel tersebut.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Gagal melakukan penyimpanan dan pencetakan. Silakan ulangi lagi.");
                }
            }
            else
                MessageBox.Show("Gagal melakukan penyimpanan dan pencetakan. Silakan ulangi lagi.");
        }

        private void pilihKategoriBtn_Click(object sender, EventArgs e)
        {
            SelectCategory();
        }

        private void hapusFilterBtn_Click(object sender, EventArgs e)
        {
            this.selectedCategory = Guid.Empty;
            kategoriTb.Text = "[Belum ada kategori dipilih]";
            RefreshView();
        }

        private void LaporanGudang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                SelectCategory();
        }

        private void dariTanggalTb_ValueChanged(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void sampaiTanggalTb_ValueChanged(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void cetakLaporanBtn_Click(object sender, EventArgs e)
        {
            PrintToExcel();
        }
    }
}
