using System;
using Banken;
using NUnit.Framework;

namespace BankenTestNUnit
{
    class KasseKreditTest
    {
        KasseKredit k;
        [SetUp]
        public void Setup()
        {
            this.k = new KasseKredit(0, 0);
        }

        [TearDown]
        public void Dispose()
        {
            // dont know what to clean up
        }

        [Test]
        public void TestKasseKreditHæv5001()
        {
            k = new KasseKredit(0, -5000);
            k.Hæv(5001);
            Assert.AreEqual(0, k.Saldo);
        }

        [Test]
        public void TestKasseKreditHæv5000()
        {
            k = new KasseKredit(0, -5000);
            k.Hæv(5000);
            Assert.AreEqual(-5000, k.Saldo);
        }
    }
}
