using System;
using Xunit;
using Banken;

namespace BankenTest
{
    public class KontoTest : IDisposable
    {
        //Konto k;
        //public KontoTest()
        //{
        //    this.k = new Konto(0);
        //}

        public void Dispose()
        {
            // dont know what to clean up
        }

        //[Fact]
        //public void TestConstructMed100kr()
        //{
        //    k = new Konto(100);
        //    Assert.Equal(100, k.saldo);
        //}

        //[Fact]
        //public void TestConstructMed0kr()
        //{
        //    //Konto k = new Konto(0);
        //    //Assert.Equal(100, k.saldo);
        //    Assert.NotEqual(100, k.saldo);
        //}

        //[Fact]
        //public void TestIndsæt100kr()
        //{
        //    //Konto k = new Konto(0);
        //    k.Indsæt(100);
        //    Assert.Equal(100, k.saldo);
        //}

        //[Fact]
        //public void TestIndsæt0kr()
        //{
        //    //Konto k = new Konto(0);
        //    k.Indsæt(0);
        //    Assert.Equal(0, k.saldo);
        //}

        //[Fact]
        //public void TestIndsætMinus100kr()
        //{
        //    //Konto k = new Konto(0);
        //    k.Indsæt(-100);
        //    Assert.Equal(0, k.saldo);
        //}

        //[Fact]
        //public void TestIndsætMegaMangeKr()
        //{
        //    //Konto k = new Konto(0);
        //    k.Indsæt(Double.MaxValue);
        //    Assert.Equal(Double.MaxValue, k.saldo);
        //}
        //[Fact]
        //public void TestIndsætMegaMangeKrPåKontoMed1kr()
        //{
        //    k = new Konto(1);
        //    //k.Indsæt(Double.MaxValue);
        //    //Assert.Equal(Double.MaxValue + 1, k.saldo);
        //    Assert.ThrowsAny<Exception>(() => k.Indsæt(Double.MaxValue));
        //}

        //[Fact]
        //public void TestHæv10krPåKontoMed100()
        //{
        //    k = new Konto(100);
        //    k.Hæv(10);
        //    Assert.Equal(90, k.saldo);
        //}

        //[Fact]
        //public void TestHæv100krPåKontoMed0()
        //{
        //    //Konto k = new Konto(0);
        //    k.Hæv(100);
        //    Assert.NotEqual(-100, k.saldo);
        //    Assert.Equal(0, k.saldo);
        //}

        //[Fact]
        //public void TestHæv100krPåKontoMed100()
        //{
        //    k = new Konto(100);
        //    k.Hæv(100);
        //    Assert.Equal(0, k.saldo);
        //}
    }
}
