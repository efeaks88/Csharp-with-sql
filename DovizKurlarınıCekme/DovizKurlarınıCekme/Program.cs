using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DovizKurlarınıCekme.Class;
using DovizKurlarınıCekme.Model;

namespace DovizKurlarınıCekme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleDbProjeEntities2 db = new ConsoleDbProjeEntities2();
            GetCurrency getCurrency = new GetCurrency();
            Sale sale = new Sale();
            void currencylist()
            {
                Console.WriteLine();
                Console.WriteLine("Döviz listesi :");
                Console.WriteLine();
                var values = db.Tbl_Currency.ToList();
                foreach (var item in values)
                {
                    Console.WriteLine(item.ID + " " + item.CurrencyName);
                }

            }

            void CurrentCurrency()
            {
                Console.WriteLine();
                Console.WriteLine("Güncel Kur listesi :");
                var values = db.Tbl_CurrencyValue.ToList();
                foreach (var item in values)
                {
                    Console.WriteLine("Döviz : " + item.Tbl_Currency.CurrencyName + " Alış : " + item.CurrencyBuying + " Satış : " + item.CurrencySelling);
                }
            }

            void GetCurrencyClass()
            {
               
               getCurrency.SaveCurrencyDollar();
                getCurrency.SaveCurrencyEuro();
                getCurrency.SaveCurrencyPound();
            }

            Console.WriteLine("Döviz işlemlerine hoş geldiniz. ");
            Console.WriteLine();
            Console.WriteLine("Mevcut kullanıcı : Admin " + "Tarih : " + DateTime.Now.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine("Yapmak istediğniiz işlemi seçin ");
            Console.WriteLine();
            Console.WriteLine("1-Döviz Listesi");
            Console.WriteLine("2-Güncel Kurlar");
            Console.WriteLine("3-Satış Yap");
            Console.WriteLine("4-Müşterilere Yapılan Satışlar");
            Console.WriteLine("5-Müşterilerden Alınan Satış Hareketleri");
            Console.WriteLine("6-Kurları veri tabanına kaydet.");
            Console.WriteLine("7-Yardım");
            Console.WriteLine("8-Çıkış Yap");
            Console.WriteLine();
            Console.Write("İşlem numarası giriniz : ");

            string choose;
            choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    currencylist();
                    break;
                case "2":
                    CurrentCurrency();
                    break;
                case "3":
                    Console.WriteLine();
                    Console.Write("Müşteri Adı :");
                    string customername=Console.ReadLine();
                    Console.Write("Müşteri SoyAdı :");
                    string customersurname = Console.ReadLine();
                    Console.Write("Döviz kodu :");
                    int currencycode = int.Parse(Console.ReadLine());
                    Console.Write("İşlem türü :");
                    string operationtype = Console.ReadLine();
                    Console.Write("Güncel kur değeri :");
                    decimal currentvalue =decimal.Parse( Console.ReadLine());
                    Console.Write("Alınacak tutar :");
                    decimal amount =decimal.Parse( Console.ReadLine());
                    Console.Write("Toplam ücret :");
                    decimal totalamount = decimal.Parse(Console.ReadLine());
                    sale.MakeSale(customername,customersurname,currencycode,operationtype,currentvalue,amount,totalamount);
                    break;
                case "4":
                    SaleOperation saleOperation = new SaleOperation();
                    saleOperation.customersaleoperationalış();
                    break;
                case "5":
                    SaleOperation saleOperation2 = new SaleOperation();
                    saleOperation2.customersaleoperationsatış();
                    break;
                case "6":
                    GetCurrencyClass();
                    Console.WriteLine("Dövizler başarılı bir şekilde kaydedildi.");
                    break;
                case "7":
                    Console.WriteLine("Tüm sorularınız için efe.aks@hotmail.com adresine ulaşabilirsiniz");
                    break;
                case "8":
                    Environment.Exit(1);
                default:
                    break;
            }
            Console.ReadLine();



        }
    }
}
