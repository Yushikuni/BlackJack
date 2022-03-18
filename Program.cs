using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karetních_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Random nahodnaCisla = new Random();
            int kartyHrace = nahodnaCisla.Next(1, 12);
            int kartyPC = nahodnaCisla.Next(1, 12);
            DalsiKarta:
            Console.WriteLine("Chcete další kartu?? ano/ne Máte " + kartyHrace);
            string volba = Console.ReadLine();
            if (volba == "ano")
            {
                kartyHrace += nahodnaCisla.Next(1, 12);
                if (kartyPC < 15)
                {
                    kartyPC += nahodnaCisla.Next(1, 12);
                }
                goto DalsiKarta;
            }
            else if (volba =="ne")
            {

                /*System.Threading.Thread.Sleep(1000);*/
                if(kartyHrace<=21 && (kartyPC>21 || kartyPC < kartyHrace))
                { 
                    Console.WriteLine("Vyhrál jsi!! Počítač měl " + kartyPC + " bodů!");
                }
                else if(kartyHrace<=21 && (kartyPC > 21 || kartyPC > kartyHrace))
                {
                    Console.WriteLine("Prohrál jsi!! Počítač měl " + kartyPC + " bodů!");
                }
                else if(kartyPC> 21 && kartyHrace>21)
                {
                    Console.WriteLine("Oba hráči prohráli!! Počítač měl " + kartyPC + " bodů!");
                }
                
                else if(kartyHrace==kartyPC)
                {
                    Console.WriteLine("Nikdo nevyhrál!!");
                }
                else if(kartyHrace>21)
                {
                    Console.WriteLine("Trubko, máš více jak 21 tuplem jsi prohrál O_o");
                }
                System.Threading.Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("Nesprávný vstup!!!");
                goto DalsiKarta;
            }
            
        }
    }
}
