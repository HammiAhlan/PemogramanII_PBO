using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220062
{
    internal class Polymorphism
    {
        public virtual void Mainan()
        {
            Console.WriteLine("Jenis Mainan");
        }
    }

    class Woody: Polymorphism
    {
        public override void Mainan()
        {
            
            Console.WriteLine("Ada ulat di sepatumu");
        }
    }
    class cengcelengan: Polymorphism
    {

        public override void Mainan()
        {
            
            Console.WriteLine("cengcelengan pig");
        }
    }
}

