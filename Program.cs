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
            Console.WriteLine("Do you wan another card?? yes/no You have: " + kartyHrace);
            string volba = Console.ReadLine();
            if (volba == "yes")
            {
                kartyHrace += nahodnaCisla.Next(1, 12);
                if (kartyPC < 15)
                {
                    kartyPC += nahodnaCisla.Next(1, 12);
                }
                goto DalsiKarta;
            }
            else if (volba == "no")
            {

                /*System.Threading.Thread.Sleep(1000);*/
                if (kartyHrace <= 21 && (kartyPC > 21 || kartyPC < kartyHrace))
                {
                    Console.WriteLine("You won!! AI had " + kartyPC + " points!");
                }
                else if (kartyHrace <= 21 && (kartyPC > 21 || kartyPC > kartyHrace))
                {
                    Console.WriteLine("You lost!! AI had " + kartyPC + " points!");
                }
                else if (kartyPC > 21 && kartyHrace > 21)
                {
                    Console.WriteLine("Both players are lost!! AI had " + kartyPC + " points!");
                }

                else if (kartyHrace == kartyPC)
                {
                    Console.WriteLine("No one wins!!");
                }
                else if (kartyHrace > 21)
                {
                    Console.WriteLine("You lost bacause you already have moore than 21! O_o");
                }
                System.Threading.Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("Incorrect input!!!");
                goto DalsiKarta;
            }

        }
    }
}