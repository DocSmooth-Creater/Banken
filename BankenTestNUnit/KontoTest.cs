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
        public void TestInds�t100kr()
        {
            k.Inds�t(100);
            Assert.AreEqual(100, k.saldo);
        }

        [Test]
        public void TestInds�t0kr()
        {
            k.Inds�t(0);
            Assert.AreEqual(0, k.saldo);
        }

        [Test]
        public void TestInds�tMinus100kr()
        {
            k.Inds�t(-100);
            Assert.AreEqual(0, k.saldo);
        }

        [Test]
        public void TestInds�tMegaMangeKr()
        {
            k.Inds�t(Double.MaxValue);
            Assert.AreEqual(Double.MaxValue, k.saldo);
        }
        [Test]
        public void TestInds�tMegaMangeKrP�KontoMed1kr()
        {
            k = new Konto(1);
            Assert.Throws<Exception>(() => k.Inds�t(Double.MaxValue));
        }

        [Test]
        public void TestH�v10krP�KontoMed100()
        {
            k = new Konto(100);
            k.H�v(10);
            Assert.AreEqual(90, k.saldo);
        }

        [Test]
        public void TestH�v100krP�KontoMed0()
        {
            k.H�v(100);
            Assert.AreNotEqual(-100, k.saldo);
            Assert.AreEqual(0, k.saldo);
        }

        [Test]
        public void TestH�v100krP�KontoMed100()
        {
            k = new Konto(100);
            k.H�v(100);
            Assert.AreEqual(0, k.saldo);
        }
    }
}