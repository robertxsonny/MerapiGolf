using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MerapiGolfLogistik;
using System.Collections.Generic;
using System.Linq;
using MerapiGolfLogistik.Models;

namespace MerapiGolfLogistikTestProject
{
    [TestClass]
    public class NotaUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            MerapiGolfLogistikEntities dbContent = new MerapiGolfLogistikEntities();
            List<NotaPembelian> notaList = dbContent.mg_nota_pembelian.ToList();
            foreach (NotaPembelian nota in notaList)
            {
                List<TotalPembelian> items = dbContent.mg_total_pembelian.Where(p => p.no_nota == nota.no_nota).ToList();
                NotaPembelianDetail notaDetail = new NotaPembelianDetail(nota, items);
                PrintNotaPembelian print = new PrintNotaPembelian(notaDetail);
            }
        }
    }
}
