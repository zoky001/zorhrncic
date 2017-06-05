using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_3_2_Testiranje;

namespace jedinicno_testiranje
{
    [TestClass]
    public class PravokutnikTest
    {
        [TestMethod]
        public void IzracunajDijagonaluTest()
        {
            Pravokutnik p1 = new Pravokutnik(0,0);
            float d1 = p1.IzracunajDijagonalu();
            Assert.AreEqual(0,d1,"izračun dijagonala nije točan");

            Pravokutnik p2 = new Pravokutnik(-5, 1);
            float d2 = p2.IzracunajDijagonalu();
            Assert.IsTrue(d2 >= 0, "dijagonala mora biti veca od nula");

            Pravokutnik p3 = new Pravokutnik(4, 3);
            float d3 = p3.IzracunajDijagonalu();
            Assert.AreEqual(5, d3, "izračun dijagonala nije točan");
        }

        [TestMethod]
        public void IzracunajPovrsinuTest()
        {
            Pravokutnik p1 = new Pravokutnik(0, 0);
            float d1 = p1.IzracunajPovrsinu();
            Assert.AreEqual(0, d1, "izračun površine nije točan");

            Pravokutnik p2 = new Pravokutnik(-1, 5);
            float d2 = p2.IzracunajPovrsinu();
            Assert.IsTrue(d2 >= 0, "površina mora biti vec od nula");

            Pravokutnik p3 = new Pravokutnik(5, 6.5f);
            float d3 = p3.IzracunajPovrsinu();
            Assert.AreEqual(32.5f, d3, "izračun povrsine nije točan");
        }

        [TestMethod]
        public void IzracunajOpsegTest()
        {
            Pravokutnik p1 = new Pravokutnik(0, 0);
            float d1 = p1.IzracunajOpseg();
            Assert.AreEqual(0, d1, "izračun opsega nije točan");

            Pravokutnik p2 = new Pravokutnik(-1, 5);
            float d2 = p2.IzracunajOpseg();
            Assert.IsTrue(d2 >= 0, "opseg mora biti vec od nula");

            Pravokutnik p3 = new Pravokutnik(5, 6.5f);
            float d3 = p3.IzracunajOpseg();
            Assert.AreEqual(23, d3, "izračun opsega nije točan");
        }
    }
}
