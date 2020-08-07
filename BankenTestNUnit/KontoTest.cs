using System;
using NUnit.Framework;
using Banken;

namespace BankenTestNUnit
{
    public class Tests
    {
        Konto k;
        [SetUp]
        public void Setup()
        {
            this.k = new Konto(0);
        }

        [TearDown]
        public void Dispose()
        {
            // dont know what to clean up
        }

        [Test]
        public void TestConstructMed100kr()
        {
            k = new Konto(100);
            Assert.AreEqual(100, k.saldo);
        }

        [Test]
        public void TestConstructMed0kr()
        {
            Assert.AreNotEqual(100, k.saldo);
        }

        [Test]
        public void TestIndsæt100kr()
        {
            k.Indsæt(100);
            Assert.AreEqual(100, k.saldo);
        }

        [Test]
        public void TestIndsæt0kr()
        {
            k.Indsæt(0);
            Assert.AreEqual(0, k.saldo);
        }

        [Test]
        public void TestIndsætMinus100kr()
        {
            k.Indsæt(-100);
            Assert.AreEqual(0, k.saldo);
        }

        [Test]
        public void TestIndsætMegaMangeKr()
        {
            k.Indsæt(Double.MaxValue);
            Assert.AreEqual(Double.MaxValue, k.saldo);
        }
        [Test]
        public void TestIndsætMegaMangeKrPåKontoMed1kr()
        {
            k = new Konto(1);
            Assert.Throws<Exception>(() => k.Indsæt(Double.MaxValue));
        }

        [Test]
        public void TestHæv10krPåKontoMed100()
        {
            k = new Konto(100);
            k.Hæv(10);
            Assert.AreEqual(90, k.saldo);
        }

        [Test]
        public void TestHæv100krPåKontoMed0()
        {
            k.Hæv(100);
            Assert.AreNotEqual(-100, k.saldo);
            Assert.AreEqual(0, k.saldo);
        }

        [Test]
        public void TestHæv100krPåKontoMed100()
        {
            k = new Konto(100);
            k.Hæv(100);
            Assert.AreEqual(0, k.saldo);
        }
    }
}