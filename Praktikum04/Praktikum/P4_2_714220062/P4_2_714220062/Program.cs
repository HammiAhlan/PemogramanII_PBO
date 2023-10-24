using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using static P4_2_714220062.FieldProperty;

namespace P4_2_714220062
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inheritance
            Console.WriteLine("Inheritance");
            tank b = new tank();
            Console.WriteLine(b. Tier);
            Console.WriteLine(b. Damage);
            b.buzzlightyear();
            b.buzzlightyear();

            //polymorphism
            Console.WriteLine("Polymorphism");
            Polymorphism c = new Woody();
            c.Mainan();
            Polymorphism d = new cengcelengan();
            d.Mainan();

            //FieldProperty
            ToyStory toyStory = new ToyStory();
            toyStory.MainCharacter = "Woody";
            toyStory.ReleaseYear = 1995;
            Console.WriteLine("Maincharacter: " + toyStory.MainCharacter);
            Console.WriteLine("Tahun Rilis: " + toyStory.ReleaseYear);



            //constructor
            Console.WriteLine("Constructor:");
            Sid sid = new Sid { nama = "Jajang Sid", umur = 11};
            Console.WriteLine(sid.nama);
            Console.WriteLine(sid.umur);
            Console.WriteLine(sid.hobi);


        }
    }
}
