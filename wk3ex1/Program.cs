using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk3ex1
{
    internal class Program
    {
        // exchange rate simulation
        static double USDToEUR = 0.98;
        static double USDToJPY = 155.62;
        static double EURToUSD = 1 / USDToEUR; static double EURToJPY = USDToJPY * USDToEUR;
        static double JPYToUSD = 1 / USDToJPY; static double JPYToEUR = 1 / EURToJPY;

        static void Main(string[] args)
        {// get amount of money
            Console.WriteLine("Enter the amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            // choose curency
            Console.WriteLine("(USD, EUR, JPY)");
            string Currency = Console.ReadLine().ToUpper();
            // perform conversion on amount
            double convertedAmountUSD = ConvertToUSD(amount, Currency);
            double convertedAmountEUR = ConvertToEUR(amount, Currency);
            double convertedAmountJPY = ConvertToJPY(amount, Currency);
            // display results
            Console.WriteLine($"USD: {convertedAmountUSD}");
            Console.WriteLine($"EUR: {convertedAmountEUR}");
            Console.WriteLine($"JPY: {convertedAmountJPY}");
        }// convert USD
        public static double ConvertToUSD(double amount, string Currency) {
            switch (Currency) { case "USD":
                    return amount;
                case "EUR":
                    return amount * EURToUSD;
                case "JPY": return amount * JPYToUSD;
                default:
                    return amount;
            } }
        // convert to eur
        public static double ConvertToEUR(double amount, string Currency)
        {
            switch (Currency){
                case "USD":
                    return amount * USDToEUR;
                case "EUR":
                    return amount;
                case "JPY": return amount * JPYToEUR;
                default:
                   return amount;

            }
        }
        // convert to jpy
        public static double ConvertToJPY(double amount, string Currency)
        {
            switch (Currency){
                case "USD":
                    return amount * USDToJPY;
                case "EUR":
                    return amount * EURToJPY;
                case "JPY": return amount;
                default:
                 return amount  ;


            }
        }


    } 
        
    }

