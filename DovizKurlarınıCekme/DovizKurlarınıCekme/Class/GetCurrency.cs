using DovizKurlarınıCekme.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DovizKurlarınıCekme.Class
{
    public class GetCurrency
    {
        ConsoleDbProjeEntities2 db = new ConsoleDbProjeEntities2();
        public void SaveCurrencyDollar()
        {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);
            string DolarAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            DolarAlis = DolarAlis.Replace(".", ",");
            string DolarSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            DolarSatis = DolarSatis.Replace(".", ",");
            Tbl_CurrencyValue t = new Tbl_CurrencyValue();
            t.CurrencyID = 1;
            t.CurrencyBuying = decimal.Parse(DolarAlis);
            t.CurrencySelling = decimal.Parse(DolarSatis);
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Tbl_CurrencyValue.Add(t);
            db.SaveChanges();
        }
        public void SaveCurrencyEuro()
        {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);
            string EuroAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            EuroAlis = EuroAlis.Replace(".", ",");
            string EuroSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            EuroSatis = EuroSatis.Replace(".", ",");
            Tbl_CurrencyValue t = new Tbl_CurrencyValue();
            t.CurrencyID = 2;
            t.CurrencyBuying = decimal.Parse(EuroAlis);
            t.CurrencySelling = decimal.Parse(EuroSatis);
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Tbl_CurrencyValue.Add(t);
            db.SaveChanges();
        }
        public void SaveCurrencyPound()
        {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);
            string PoundAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteBuying").InnerXml;
            PoundAlis = PoundAlis.Replace(".", ",");
            string PoundSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
            PoundSatis = PoundSatis.Replace(".", ",");
            Tbl_CurrencyValue t = new Tbl_CurrencyValue();
            t.CurrencyID = 4;
            t.CurrencyBuying = decimal.Parse(PoundAlis);
            t.CurrencySelling = decimal.Parse(PoundSatis);
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Tbl_CurrencyValue.Add(t);
            db.SaveChanges();
        }
    }
}
