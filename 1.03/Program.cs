using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //At a restaurant, Mike and his three friends decided to divide the bill evenly. 
            //If each person paid $13 then what was the total bill?

            //declares variables
            int totalBill;
            int numberFriends = 4;
            int individualPortion = 13;

            //Calculation
            totalBill = numberFriends * individualPortion;

            Console.WriteLine(totalBill);
            Console.ReadKey();
            */

            /*
            //Last Friday Trevon had $29. Over the weekend he recieved some money for
            //cleaning the attic. He now has $41. How much money did he recieve?

            int startingBalance = 29;
            int currentBalance = 41;
            int cleaningAtticPay;

            cleaningAtticPay = currentBalance - startingBalance;

            Console.WriteLine(cleaningAtticPay);
            Console.ReadKey();
            */


            /*
            //How many boxes of envelopes can you buy with $12 if one box costs $3?

            int oneBox = 3;
            int totalBoxesEnvelopes;
            int envelopeBudget = 12;

            totalBoxesEnvelopes = envelopeBudget / oneBox;

            Console.WriteLine(totalBoxesEnvelopes);
            Console.ReadKey();
            */

            //331 students went on a field trip. Six buses were filled and 
            //7 students traveled in cars. How many students were in each bus?

            /*
            int totalStudents = 331;
            int carStudents = 7;
            int totalBusses = 6;
            int studentsPerBus;

            studentsPerBus = totalStudents - carStudents;
            studentsPerBus = studentsPerBus / totalBusses;

            Console.WriteLine(studentsPerBus);
            Console.ReadKey();
            */

            //The sum of three consecutive numbers is 72. 
            //What are the smallest of these numbers?

            int totalSum = 72;
            int totalNum = 3;
            int smallestNum = 0;
            int num1;
            int num2;
            int num3;
            

            num1 = totalSum / totalNum;
            num2 = (num1 - 1);
            num3 = (num1 + 1);

            if ((num1 < num2) && (num1 < 3))
            {
                smallestNum = num1;
            }
            else if ((num2 < num1) && (num2 < num3))
            {
                smallestNum = num2;
            }
            else if ((num3 < num1) && (num3 < num2))
            {
                smallestNum = num3;
            }
            Console.WriteLine(smallestNum);
            Console.ReadKey();












        }
    }
}
