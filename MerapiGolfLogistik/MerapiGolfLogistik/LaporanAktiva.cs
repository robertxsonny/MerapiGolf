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
    public partial class LaporanAktiva : Form
    {
        private MerapiGolfLogistikEntities dbContent = new MerapiGolfLogistikEntities();
        private Guid selectedAktiva = Guid.Empty;
        private List<LaporanAktivaModel> report;
        public LaporanAktiva()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.ActiveControl = this.reportView;
            this.StartPosition = FormStartPosition.CenterScreen;
            RefreshView();
        }

        private void SelectAktiva()
        {
            PilihAktiva pilihform = new PilihAktiva();
            var dlgmsg = pilihform.ShowDialog();
            if (dlgmsg == DialogResult.OK)
            {
                this.selectedAktiva = pilihform.selectedId;
                var aktiva = dbContent.mg_aktiva.Where(p => p.id == this.selectedAktiva).Single();
                aktivaTb.Text = aktiva.nama_aktiva;
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
            report = new Classes.FetchData().GetReportByAktiva(this.selectedAktiva, start, end).ToList();

            reportView.DataSource = null;
            reportView.DataSource = report;
            reportView.DefaultCellStyle.FormatProvider = new CultureInfo("id-ID");
        }

        private void PrintToExcel()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel File (*.xlsx)|*.xlsx";
            sfd.FileName = "Laporan Barang per Aktiva " + dariTanggalTb.Value.ToString("ddMMyyyy", new CultureInfo("id-ID")) + " - " + sampaiTanggalTb.Value.ToString("ddMMyyyy", new CultureInfo("id-ID")) + ".xlsx";
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


                        sheet1.Cells["B4"].Value = "LAPORAN PENGELUARAN BARANG PER AKTIVA";
                        sheet1.Cells["B4:H4"].Merge = true;
                        sheet1.Cells["B5"].Value = "PERIODE";
                        sheet1.Cells["B5:C5"].Merge = true;
                        sheet1.Cells["D5"].Value = ": " + dariTanggalTb.Value.ToString("dd MMMM yyyy", new CultureInfo("id-ID")) + " - " + 
                            sampaiTanggalTb.Value.ToString("dd MMMM yyyy", new CultureInfo("id-ID"));
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
                        sheet1.Cells["C8"].Value = "URAIAN";
                        sheet1.Cells["C8:C9"].Merge = true;
                        sheet1.Cells["D8"].Value = "JUMLAH";
                        sheet1.Cells["D9"].Value = "KELUAR";
                        sheet1.Cells["E8"].Value = "AWAL";
                        sheet1.Cells["E8:E9"].Merge = true;
                        sheet1.Cells["F8"].Value = "AKHIR";
                        sheet1.Cells["F8:F9"].Merge = true;
                        sheet1.Cells["G8"].Value = "HARGA";
                        sheet1.Cells["G9"].Value = "PER UNIT";
                        sheet1.Cells["H8"].Value = "JUMLAH";
                        sheet1.Cells["H9"].Value = "HARGA";
                        sheet1.Cells["I8"].Value = "SALDO";
                        sheet1.Cells["I8:J8"].Merge = true;
                        sheet1.Cells["I9"].Value = "AWAL";
                        sheet1.Cells["J9"].Value = "AKHIR";

                        ExcelRange range2 = sheet1.Cells["A8:J9"];
                        range2.Style.Font.Bold = true;
                        range2.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        range2.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;

                        var grouped = this.report.GroupBy(p => p.id_aktiva);
                        int index = 1;
                        int row = 11; //start from row 12
                        double totalharga = 0;
                        double totalsaldoawal = 0;
                        double totalsaldoakhir = 0;
                        foreach (var group in grouped)
                        {
                            row++;
                            sheet1.Cells[row, 3].Value = group.First().nama_aktiva;
                            sheet1.Cells[row, 3, row, 10].Merge = true;
                            sheet1.Cells[row, 3, row, 10].Style.Font.Bold = true;
                            //iterate the items
                            foreach (var item in group)
                            {
                                row++;
                                //jumlah harga
                                totalharga += item.harga_pembelian;
                                totalsaldoawal += item.saldoawal;
                                totalsaldoakhir += item.saldoakhir;

                                sheet1.Cells[row, 1].Value = index.ToString();
                                sheet1.Cells[row, 2].Value = item.subsi_barang;
                                sheet1.Cells[row, 3].Value = item.nama_barang;
                                sheet1.Cells[row, 4].Value = item.jumlah_diambil;
                                sheet1.Cells[row, 5].Value = item.stokawal;
                                sheet1.Cells[row, 6].Value = item.stokakhir;
                                sheet1.Cells[row, 7].Value = item.harga_per_unit.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
                                sheet1.Cells[row, 8].Value = item.harga_pembelian.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
                                sheet1.Cells[row, 9].Value = item.saldoawal.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
                                sheet1.Cells[row, 10].Value = item.saldoakhir.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
                                sheet1.Cells[row, 6, row, 10].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;
                                row++;
                                index++;
                            }
                        }

                        //set subtotal
                        row++;
                        sheet1.Cells[row, 1].Value = "JUMLAH";
                        sheet1.Cells[row, 1, row, 7].Merge = true;
                        sheet1.Cells[row, 8].Value = totalharga.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
                        sheet1.Cells[row, 9].Value = totalsaldoawal.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
                        sheet1.Cells[row, 10].Value = totalsaldoakhir.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
                        sheet1.Cells[row, 1, row, 10].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;
                        sheet1.Cells[row, 1, row, 10].Style.Font.Bold = true;

                        //set border
                        for (int i = 8; i <= row; i++)
                        {
                            for (int j = 1; j <= 10; j++)
                            {
                                sheet1.Cells[i, j].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin, Color.Black);
                            }
                        }

                        //autofit
                        sheet1.Cells[1, 8, row, 10].AutoFitColumns();

                        excelFile.SaveAs(file);

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
            SelectAktiva();
        }

        private void hapusFilterBtn_Click(object sender, EventArgs e)
        {
            this.selectedAktiva = Guid.Empty;
            aktivaTb.Text = "[Belum ada kategori dipilih]";
            RefreshView();
        }

        private void LaporanGudang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                SelectAktiva();
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
