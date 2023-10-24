using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220062
{
    internal class Inheritance
    {
    }
    public class tank
    {
        public string Tier { get; set; }
        public int Damage { get; set; }

        public void buzzlightyear() {

            Console.WriteLine("menuju tak terbatas dan melampauinya wuuuzz");

            {

            }
        }
        class Panzer : tank
        {
            public Panzer()
            {
                Tier = "10";
                Damage = 500;
            }
            public void tiger()
            {
                Console.WriteLine("Damage gede");
            }

        }

    }
        }
      

    

