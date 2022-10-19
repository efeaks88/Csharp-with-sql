using DovizKurlarınıCekme.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DovizKurlarınıCekme.Class
{
    public class Sale
    {
        ConsoleDbProjeEntities2 db = new ConsoleDbProjeEntities2();
        public void MakeSale(string customername,string customersurname,int currencycode,string operationtype,decimal currentvalue,decimal amount,decimal totalprice)
        {
            Tbl_Operation t = new Tbl_Operation();
            t.CustomerName = customername;
            t.CustomerSurName = customersurname;
            t.CurrencyID = currencycode;
            t.OperationType = operationtype;
            t.CurrentValue=currentvalue;
            t.Amount = amount;
            t.TotalPrice = totalprice;
            t.Date =DateTime.Parse (DateTime.Now.ToShortDateString());
            db.Tbl_Operation.Add(t);
            db.SaveChanges();
            Console.WriteLine("Satış işlemi başarılı bir şekilde gerçekleşti.");

        }
    }
}
