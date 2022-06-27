using System;
using ATM.BankomatoReikalai;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankomatas = new Bankomatas(new KlientuInformacija.KlientuDuomenu_Repozitorija(), new KlientuInformacija.Transakciju_Repozitorija());
            bankomatas.ATM();

        }
    }
}
