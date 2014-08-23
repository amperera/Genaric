using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genaric
{
    class Program
    {
        static void Main(string[] args)
        {
            var dd = new Settingdata<int,string> { MyProperty = 1, data = 5, Data2 ="this is string"};

            var pp = new print();
            pp.Printingdata(dd);

            Console.ReadLine();
        }
    }

    public class Settingdata<T,K>
    {
        public int MyProperty { get; set; }
        public T data { get; set; }

        public K Data2 { get; set; }
    }
    public class print
    {
        public void Printingdata<T, K>(Settingdata<T, K> data)
        {

            Console.WriteLine(data.MyProperty);
            Console.WriteLine(data.data);
            Console.WriteLine(data.Data2);
        }
    }


  
}
