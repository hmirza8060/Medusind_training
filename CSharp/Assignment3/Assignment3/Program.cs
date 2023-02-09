//using System;
//using System.Xml.Linq;


//namespace Assignment3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            SalesDetails sd = new SalesDetails(101, 110, 5, 5, "2012/01/01");
//            Console.Read();
//        }
//    }
//    public class SalesDetails
//    {
//        public int salesNo, productNo, price, qty, totalAmount;
//        string dateofsale;
//        public SalesDetails(int s, int pno, int p, int q, string dos)
//        {
//            this.salesNo = s;
//            this.productNo = pno;
//            this.price = p;
//            this.qty = q;
//            this.dateofsale = dos;
//            Console.WriteLine(Convert.ToString(s));
//        }
//    }
//    public void show()
//    {
//        Sales s = new Sales();
//        Console.WriteLine(sale);
//    }
//    public class Sales : SalesDetails
//    {

//        public Sales(int s, int pno, int p, int q, string dos) : base(s, pno, p, q, dos)
//        {

//        }
//    }
//}
using System;


namespace Assignment3
{
    internal class doctors
    {
        private int regNo, fees;
        private string Name;
        public string _name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
    class Program : doctors
    {
        static void Main(string[] args)
        {
            doctors d = new doctors();
            d._name = "hasnain";
            Console.WriteLine(d._name);
            Console.Read();
        }
    }
}
