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
    public partial class LaporanPergerakan : Form
    {
        private MerapiGolfLogistikEntities dbContent = new MerapiGolfLogistikEntities();
        private Guid selectedCategory = Guid.Empty;
        private List<LaporanPergerakanModel> report;
        public LaporanPergerakan()
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
            report = new Classes.FetchData().GetMovementReport(this.selectedCategory, start, end).ToList();

            reportView.DataSource = null;
            //reportView.DataSource = result;
            reportView.DataSource = report;
            reportView.DefaultCellStyle.FormatProvider = new CultureInfo("id-ID");
        }

        private void PrintToExcel()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel File (*.xlsx)|*.xlsx";
            sfd.FileName = "Laporan Pergerakan Barang " + dariTanggalTb.Value.ToString("ddMMyyyy", new CultureInfo("id-ID")) + " - " + sampaiTanggalTb.Value.ToString("ddMMyyyy", new CultureInfo("id-ID")) + ".xlsx";
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
                        sheet1.Cells[1, 1].Value = "LAPORAN PERGERAKAN BARANG";
                        sheet1.Cells[2, 1].Value = "PT. MERAPI GOLF YOGYAKARTA";
                        sheet1.Cells[3, 1].Value = "Periode: " + dariTanggalTb.Value.ToString("dd MMMM yyyy", CultureInfo.GetCultureInfo("id-ID")) +
                            " - " + sampaiTanggalTb.Value.ToString("dd MMMM yyyy", CultureInfo.GetCultureInfo("id-ID"));
                        for (int i = 1; i <= 3; i++)
                        {
                            sheet1.Cells[i, 1, i, 9].Merge = true;
                            sheet1.Cells[i, 1, i, 9].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                            sheet1.Cells[i, 1, i, 9].Style.Font.Bold = true;
                        }

                        sheet1.Cells[5, 1].Value = "CATEGORY | PRODUCT (UNIT)";
                        sheet1.Cells[5, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        sheet1.Cells[5, 1].Style.Font.Bold = true;
                        sheet1.Cells[5, 1, 5, 3].Merge = true;
                        sheet1.Cells[6, 1].Value = "Transaction Date/Type";
                        sheet1.Cells[6, 1, 6, 3].Merge = true;
                        sheet1.Cells[6, 4].Value = "Return To Ref.#";
                        sheet1.Cells[6, 5].Value = "Qty.";
                        sheet1.Cells[6, 6].Value = "Amount";
                        sheet1.Cells[6, 7].Value = "Amount/Qty";
                        sheet1.Cells[6, 8].Value = "Qty. Balance";
                        sheet1.Cells[6, 9].Value = "Amt. Balance";
                        sheet1.Cells[6, 1, 6, 10].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                        for (int i = 1; i <= 9; i++)
                        {
                            sheet1.Cells[6, i].Style.Font.Bold = true;
                            sheet1.Cells[6, i].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        }
                        sheet1.Cells[7, 1].Value = "BAGIAN UMUM";
                        sheet1.Cells[7, 1].Style.Font.Bold = true;
                        sheet1.Cells[7, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                        var catsgrp = this.report.GroupBy(p => p.id_kategori);
                        int row = 7;
                        //iterate category
                        foreach (var catgrp in catsgrp)
                        {
                            var itemsgrp = catgrp.GroupBy(p => p.id_barang);
                            //iterate item group
                            foreach (var itemgrp in itemsgrp)
                            {
                                row++;
                                var firstitem = itemgrp.FirstOrDefault();
                                sheet1.Cells[row, 1].Value = firstitem.nama_kategori + " | " +
                                    firstitem.subsi_kategori + "   " + firstitem.subsi_barang + " : " + firstitem.nama_barang + " (EACH)";
                                sheet1.Cells[row, 1, row,6].Merge = true;
                                sheet1.Cells[row, 7].Value = "B/Fwd";
                                sheet1.Cells[row, 8].Value = firstitem.quantity_awal.ToString();
                                sheet1.Cells[row, 9].Value = firstitem.balance_awal.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
                                sheet1.Cells[row, 1, row, 7].Style.Font.Bold = true;
                                //iterate item
                                foreach (var item in itemgrp)
                                {
                                    row++;
                                    sheet1.Cells[row, 1].Value = item.tanggal_trx.ToString("dd-MM-yyyy");
                                    sheet1.Cells[row, 2].Value = item.tipe_pergerakan_str;
                                    sheet1.Cells[row, 3].Value = item.tanggal_trx.ToString("dd/MM/yyyy");
                                    sheet1.Cells[row, 5].Value = item.quantity.ToString();
                                    sheet1.Cells[row, 6].Value = item.totalprice.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
                                    sheet1.Cells[row, 7].Value = item.unitprice.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
                                    sheet1.Cells[row, 8].Value = item.quantity_balance.ToString();
                                    sheet1.Cells[row, 9].Value = item.balance.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
                                }
                            }
                        }

                        //autofit
                        sheet1.Cells[6, 1, row, 9].AutoFitColumns();

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
