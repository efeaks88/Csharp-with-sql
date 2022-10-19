using DovizKurlarınıCekme.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DovizKurlarınıCekme.Class
{
    public class SaleOperation
    {
        public void customersaleoperationalış()
        {
            ConsoleDbProjeEntities2 db = new ConsoleDbProjeEntities2();
            var values = db.Tbl_Operation.Where(x => x.OperationType == "alış").ToList();
            foreach (var item in values)
            {
                Console.WriteLine("ID: " + item.ID + " " + "Müşteri : " + item.CustomerName + " " + item.CustomerSurName + " " + "Döviz : " + item.Tbl_Currency.CurrencyName + " İşlem Türü : " + item.OperationType + " Kur değeri " + item.CurrentValue + "Alınan tutar : " + item.Amount + " Toplam Tutar" + item.TotalPrice);
            }
        }
        public void customersaleoperationsatış()
        {
            ConsoleDbProjeEntities2 db = new ConsoleDbProjeEntities2();
            var values = db.Tbl_Operation.Where(x => x.OperationType == "satış").ToList();
            foreach (var item in values)
            {
                Console.WriteLine("ID: " + item.ID + " " + "Müşteri : " + item.CustomerName + " " + item.CustomerSurName + " " + "Döviz : " + item.Tbl_Currency.CurrencyName + " İşlem Türü : " + item.OperationType + " Kur değeri " + item.CurrentValue + "Alınan tutar : " + item.Amount + " Toplam Tutar" + item.TotalPrice);
            }
        }
    }
}
