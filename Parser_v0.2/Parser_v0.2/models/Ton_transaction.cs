using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser_v0._2.models
{
    public class Ton_transaction
    {
        public Ton_transaction(string date, string typeOfTransaction, string wallet, double amountOfTon)
        {
            Date = date;
            TypeOfTransaction = typeOfTransaction;
            Wallet = wallet;
            AmountOfTon = amountOfTon;
        }

        public string Date { get; set; }
        public string TypeOfTransaction { get; set; }
        public string Wallet { get; set; }
        public double AmountOfTon { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Ton_transaction transaction &&
                   AmountOfTon == transaction.AmountOfTon;
        }

        public override int GetHashCode()
        {
            return 379430793 + AmountOfTon.GetHashCode();
        }

        public override string ToString()
        => $"Date:{Date}, Type:{TypeOfTransaction}, Wallet:{Wallet}, Amount:{AmountOfTon} TON";
    }
}
