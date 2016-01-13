using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MerapiGolfLogistik.Classes;

namespace MerapiGolfLogistikTestProject
{
    [TestClass]
    public class PembelianUnitTest
    {
        [TestMethod]
        public void GenerateNotaTest()
        {
            PembelianBarang pembelian = new PembelianBarang();
            string current = "T999998";
            string result = pembelian.GenerateNoNota(current);
            Assert.AreEqual("T999999", result);
        }
    }
}
