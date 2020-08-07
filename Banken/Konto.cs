using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    public class Konto
    {
        public Konto(double startSaldo)
        {
            saldo = startSaldo;
        }

        public double saldo { get; private set; }

        public void Indsæt(double beløb)
        {
            if (beløb > 0)
                this.saldo += beløb;
        }

        public void Hæv(double beløb)
        {
            if (saldo >= beløb)
            {
                saldo -= beløb;
            }
        }

    }

    public class KasseKredit
    {
        public KasseKredit(double saldo, double KreditNum)
        {
            this.Saldo = saldo;
            this.KreditNum = KreditNum;
        }
        private double saldo;
        private double kreditNum;
        public double Saldo 
        { 
            get 
            {
                return saldo;
            } 
            set 
            {
                saldo = value;
            }
        }
        public double KreditNum { get { return kreditNum; } set { kreditNum = value; } }


        public void Indsæt(double beløb)
        {
            if (beløb > 0)
                this.saldo += beløb;
        }

        public void Hæv(double beløb)
        {
            if((Saldo - beløb) >= KreditNum)
                Saldo -= beløb;
        }
    }
}
