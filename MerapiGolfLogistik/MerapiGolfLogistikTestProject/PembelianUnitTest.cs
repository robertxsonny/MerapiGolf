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
            string current = "A000004";
            string result = pembelian.GenerateNoNota(current);
            Assert.AreEqual("A000005", result);
        }

    }
}
