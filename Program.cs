using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonavljanjeDessert
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person[] osobe = new Person[5];

            osobe[0] = new Student();
            osobe[1] = new Student();
            osobe[0] = new Teacher();
            osobe[1] = new Teacher();
            osobe[1] = new Teacher();



            /* Console.WriteLine("Unesi svoj omiljeni kolac( ime, tezina, kalorije, gluten, tip kolaca):\n");
             string ime = Console.ReadLine();
             int tezina = Convert.ToInt32(Console.ReadLine());
             int kalorije = Convert.ToInt32(Console.ReadLine());
             string unos = Console.ReadLine();
             bool gluten;
             if (unos == "yes" || unos == "da" || unos == "1")
                 gluten = true;
             else
                 gluten = false;
             string tip = Console.ReadLine();
             Cake kolac = new Cake(ime,tezina,kalorije,gluten,tip);

             Console.WriteLine("Unesi svoj omiljeni sladoled ( ime, tezina, kalorije, okus i boja ) :\n");
              ime = Console.ReadLine();
             tezina = Convert.ToInt32(Console.ReadLine());
             kalorije = Convert.ToInt32(Console.ReadLine());
             string okus = Console.ReadLine();
             string boja = Console.ReadLine();

             IceCream sladoled = new IceCream(ime, tezina, kalorije, okus, boja);*/
        }
    }
}





