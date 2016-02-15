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

        //private void PrintToExcel()
        //{
        //    SaveFileDialog sfd = new SaveFileDialog();
        //    sfd.Filter = "Excel File (*.xlsx)|*.xlsx";
        //    sfd.FileName = "Laporan Barang per Kategori " + dariTanggalTb.Value.ToString("ddMMyyyy", new CultureInfo("id-ID")) + " - " + sampaiTanggalTb.Value.ToString("ddMMyyyy", new CultureInfo("id-ID")) + ".xlsx";
        //    sfd.FilterIndex = 1;
        //    var result = sfd.ShowDialog();
        //    if (result == DialogResult.OK)
        //    {
        //        try
        //        {
        //            FileInfo file = new FileInfo(sfd.FileName);
        //            if (file.Exists)
        //            {
        //                file.Delete();
        //            }

        //            using (ExcelPackage excelFile = new ExcelPackage())
        //            {
        //                ExcelWorksheet sheet1 = excelFile.Workbook.Worksheets.Add("Laporan Gudang");
        //                sheet1.Cells[1, 1].Value = "LAPORAN BARANG PER KATEGORI";
        //                sheet1.Cells[2, 1].Value = "PT. MERAPI GOLF YOGYAKARTA";
        //                sheet1.Cells[3, 1].Value = "Periode: " + dariTanggalTb.Value.ToString("dd MMMM yyyy", CultureInfo.GetCultureInfo("id-ID")) +
        //                    " - " + sampaiTanggalTb.Value.ToString("dd MMMM yyyy", CultureInfo.GetCultureInfo("id-ID"));
        //                for (int i = 1; i <= 3; i++)
        //                {
        //                    sheet1.Cells[i, 1, i, 10].Merge = true;
        //                    sheet1.Cells[i, 1, i, 10].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
        //                    sheet1.Cells[i, 1, i, 10].Style.Font.Bold = true;
        //                }

        //                sheet1.Cells[5, 1].Value = "CATEGORY";
        //                sheet1.Cells[5, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
        //                sheet1.Cells[5, 1].Style.Font.Bold = true;
        //                sheet1.Cells[6, 1].Value = "PRODUCT (UNIT)";
        //                sheet1.Cells[6, 4].Value = "B/Fwd";
        //                sheet1.Cells[6, 5].Value = "(+) Receive";
        //                sheet1.Cells[6, 6].Value = "(+/-) Issue";
        //                sheet1.Cells[6, 7].Value = "(+/-) Adjustment";
        //                sheet1.Cells[6, 8].Value = "(-) Sales";
        //                sheet1.Cells[6, 9].Value = "Return";
        //                sheet1.Cells[6, 10].Value = "Balance";
        //                sheet1.Cells[6, 1, 6, 10].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
        //                for (int i = 1; i <= 10; i++)
        //                {
        //                    sheet1.Cells[6, i].Style.Font.Bold = true;
        //                    sheet1.Cells[6, i].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
        //                }
        //                sheet1.Cells[7, 1].Value = "BAGIAN UMUM";
        //                sheet1.Cells[7, 1].Style.Font.Bold = true;
        //                sheet1.Cells[7, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

        //                var itemsgrp = this.report.GroupBy(p => p.id_kategori);
        //                int row = 8;
        //                double saldo = 0;
        //                double saldomasuk = 0;
        //                double saldokeluar = 0;
        //                double saldokembali = 0;
        //                double sisasaldo = 0;
        //                foreach (var itemgrp in itemsgrp)
        //                {
        //                    row++;
        //                    double saldocat = 0;
        //                    double saldomasukcat = 0;
        //                    double saldokeluarcat = 0;
        //                    double saldokembalicat = 0;
        //                    double sisasaldocat = 0;
        //                    sheet1.Cells[row, 1].Value = itemgrp.First().nama_kategori;
        //                    sheet1.Cells[row, 1].Style.Font.Bold = true;
        //                    row++;
        //                    foreach (var item in itemgrp)
        //                    {
        //                        //row quantity
        //                        sheet1.Cells[row, 1].Value = item.subsi_kategori;
        //                        sheet1.Cells[row, 2].Value = item.subsi_barang + " (EACH)";
        //                        sheet1.Cells[row, 3].Value = "Qty.";
        //                        sheet1.Cells[row, 4].Value = item.stok;
        //                        sheet1.Cells[row, 5].Value = item.stokmasuk;
        //                        sheet1.Cells[row, 6].Value = item.stokkeluar;
        //                        sheet1.Cells[row, 7].Value = "0,00";
        //                        sheet1.Cells[row, 8].Value = "0,00";
        //                        sheet1.Cells[row, 9].Value = item.stokkembali;
        //                        sheet1.Cells[row, 10].Value = item.sisastok;
        //                        row++;
        //                        sheet1.Cells[row, 1].Value = item.nama_barang + " (EACH)";
        //                        sheet1.Cells[row, 1, row, 2].Merge = true;
        //                        sheet1.Cells[row, 3].Value = "Amt.";
        //                        sheet1.Cells[row, 4].Value = item.saldo.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
        //                        sheet1.Cells[row, 5].Value = item.saldomasuk.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
        //                        sheet1.Cells[row, 6].Value = item.saldokeluar.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
        //                        sheet1.Cells[row, 7].Value = "0,00";
        //                        sheet1.Cells[row, 8].Value = "0,00";
        //                        sheet1.Cells[row, 9].Value = item.saldokembali.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
        //                        sheet1.Cells[row, 10].Value = item.sisasaldo.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
        //                        //border bottom
        //                        sheet1.Cells[(row - 1), 1, row, 10].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thick);
        //                        row++;

        //                        //add to category subtotal
        //                        saldocat += item.saldo;
        //                        saldomasukcat += item.saldomasuk;
        //                        saldokeluarcat += item.saldokeluar;
        //                        saldokembalicat += item.saldokembali;
        //                        sisasaldocat += item.sisasaldo;
        //                        //add to location subtotal
        //                        saldo += item.saldo;
        //                        saldomasuk += item.saldomasuk;
        //                        saldokeluar += item.saldokeluar;
        //                        saldokembali += item.saldokembali;
        //                        sisasaldo += item.sisasaldo;
        //                    }
                            
        //                    sheet1.Cells[row, 1].Value = "Category Subtotal";
        //                    sheet1.Cells[row, 1, row, 3].Merge = true;
        //                    sheet1.Cells[row, 4].Value = saldocat.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
        //                    sheet1.Cells[row, 5].Value = saldomasukcat.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
        //                    sheet1.Cells[row, 6].Value = saldokeluarcat.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
        //                    sheet1.Cells[row, 7].Value = "0,00";
        //                    sheet1.Cells[row, 8].Value = "0,00";
        //                    sheet1.Cells[row, 9].Value = saldokembalicat.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
        //                    sheet1.Cells[row, 10].Value = sisasaldocat.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);

        //                    //autofit
        //                    sheet1.Cells[5, 1, row, 10].AutoFitColumns();
        //                    //fit alignment right for numbers
        //                    sheet1.Cells[9, 4, row, 10].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;

        //                }

        //                //location total
        //                row++;
        //                sheet1.Cells[row, 1].Value = "Location Subtotal";
        //                sheet1.Cells[row, 1, row, 3].Merge = true;
        //                sheet1.Cells[row, 4].Value = saldo.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
        //                sheet1.Cells[row, 5].Value = saldomasuk.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
        //                sheet1.Cells[row, 6].Value = saldokeluar.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
        //                sheet1.Cells[row, 7].Value = "0,00";
        //                sheet1.Cells[row, 8].Value = "0,00";
        //                sheet1.Cells[row, 9].Value = saldokembali.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
        //                sheet1.Cells[row, 10].Value = sisasaldo.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);


        //                excelFile.SaveAs(file);
        //                //excelFile.File.Open(FileMode.Open);

        //                MessageBox.Show("Berhasil menyimpan laporan ke dalam format Excel. Silakan lakukan pencetakan dari file Excel tersebut.");
        //            }
        //        }
        //        catch (Exception)
        //        {
        //            MessageBox.Show("Gagal melakukan penyimpanan dan pencetakan. Silakan ulangi lagi.");
        //        }
        //    }
        //    else
        //        MessageBox.Show("Gagal melakukan penyimpanan dan pencetakan. Silakan ulangi lagi.");
        //}

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
            //PrintToExcel();
        }
    }
}
