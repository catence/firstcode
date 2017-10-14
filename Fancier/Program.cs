using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancier
{
    public abstract class Program
    {
        static void Main(string[] args)
        {
            cate myString = new cate();
            myString.cook();
        }
    }
    class cynthia
    {
        public int MyProperty { get;}
        public void cook()
        {
            Console.Write("Print this");
        }
    }
    class cate:cynthia
    {
        public cate():base()
        {
           //cook();       
        }
    }
}
