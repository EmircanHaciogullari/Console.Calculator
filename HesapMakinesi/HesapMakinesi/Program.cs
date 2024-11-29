using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayi1,sayi2;
            string Yapılmakİstenenİşlem;
            Console.Write("Please Enter a Number :");
            sayi1=Convert.ToDouble(Console.ReadLine());

            Console.Write("Please Enter a Number Again:");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Action You Want to Perfom: ");
            Console.WriteLine("For Plus (+), For Minus(-),For Divide(/)" + ",For İmcapt (*)");

            Yapılmakİstenenİşlem = Console.ReadLine();

            switch (Yapılmakİstenenİşlem)
            {
                case "+":
                    Console.WriteLine("Conclusion: " + (sayi1 + sayi2));
                    break;
                case "-":
                    Console.WriteLine("Conclusion: " + (sayi1 - sayi2));
                    break;
                case "*":
                    Console.WriteLine("Conclusion: " + (sayi1 * sayi2));
                    break;
                case "/":
                    Console.WriteLine("Conclusion: " + (sayi1 / sayi2));
                    break;
                default:
                    Console.WriteLine("You Enter Wrong Key");
                    break;

            }
            Console.Read();

            }
    }
}
