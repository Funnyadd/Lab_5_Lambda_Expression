using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lambda___Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            List<int> intList = new List<int>() { 6, 5, 4, 3, 2, 1, 7, 10, 1 };

            Console.WriteLine("Part 1:");

            LessThan5(intList); //Question 1 
            LowestNumber(intList); //Question 2
            LowerThanAverage(intList); //Question 3
            Console.WriteLine();

            //Part 2
            Console.WriteLine("Part 2:");
            Dictionary<int, string> indexedList = new Dictionary<int, string>();
            indexedList.Add(1, "Green Division");
            indexedList.Add(2, "Yellow Division");
            indexedList.Add(3, "Blue Division");
            indexedList.Add(4, "Pink Division");
            indexedList.Add(5, "Dark Blue Division");
            
            BlueInString(indexedList); //Question 4
            MoreThan4Letters(indexedList); //Question 5
            ConvertToBank(indexedList); //Question 6

            //Part 3
            Console.WriteLine("Part 3:");
            List<Account> accountList = new List<Account>();
            accountList.Add(new Account { id = 123, name = "Eastern Division", balance = 12332.33 });
            accountList.Add(new Account { id = 234, name = "Western Division", balance = 22333333.22 });
            accountList.Add(new Account { id = 345, name = "Northern Division", balance = 2184.34 });
            accountList.Add(new Account { id = 456, name = "Southern Division", balance = 999222.00 });
            accountList.Add(new Account { id = 567, name = "Champlain Wireless Division", balance = 00.01 });

            GetAverage(accountList);
            AverageOver10000(accountList);
            BalanceOver10000(accountList);
        }

        //Part 1 *
        //Question 1 
        public static void LessThan5(List<int> intList)
        {
            // Values that are less than 5
            var lessThan5 = intList.Where(y => y < 5);
            Console.Write("Values less than 5: ");

            foreach (var x in lessThan5)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }

        //Question 2
        public static void LowestNumber(List<int> intList)
        {
           int lowestNum = intList.Min();
            Console.WriteLine("The minimum value in the list is: {0}", lowestNum);
        }

        //Question 3
        public static void LowerThanAverage(List<int> intList)
        {
            var lowerThanAverage = intList.Where(y => y < intList.Average());
            Console.Write("Values lower than the average of the list: ");

            foreach (var x in lowerThanAverage)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }

        //Part 2 *
        //Question 4
        public static void BlueInString(Dictionary<int, string> indexedList)
        {
            var blueInString = indexedList.Where(str => str.Value.Contains("Blue"));
            Console.Write("Records with the color blue: ");

            foreach (var x in blueInString)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }

        //Question 5
        public static void MoreThan4Letters(Dictionary<int, string> indexedList)
        {
            var moreThan4Letters = indexedList.Where(str => str.Value.Count() - 9 > 4); // -9 is to get out the word 'division'
            Console.Write("Records colors that have more than 4 letters: ");

            foreach (var x in moreThan4Letters)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\n");
        }

        //Question 6
        public static void ConvertToBank(Dictionary<int, string> indexedList)
        {
            Console.WriteLine("Bank Statements: ");

            indexedList = indexedList.ToDictionary(y => y.Key * 1000, y => y.Value);

            foreach (var x in indexedList)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
        }

        //Part 3 *
        //Question 7
        public static void GetAverage(List<Account> accountList)
        {
            Console.Write("The average for the balance of each account of this list is: ");
            double getAverage = accountList.Average(y => y.balance);

            Console.WriteLine(getAverage);
        }

        //Question 8
        public static void AverageOver10000(List<Account> accountList)
        {
            Console.Write("The average where balance is over 10000 is: ");
            double averageOver10000 = accountList.Where(y => y.balance > 10000).Average(y => y.balance);
            Console.WriteLine(averageOver10000);
        }

        //Question 9
        public static void BalanceOver10000(List<Account> accountList)
        {
            Console.WriteLine("\nBank account with a balance over 10000:");
            var balanceOver10000 = accountList.Where(y => y.balance > 10000);
            
            foreach (var x in balanceOver10000)
            {
                Console.Write(x.id + " ");
                Console.Write(x.name + " ");
                Console.WriteLine(x.balance + " ");
            }
            Console.WriteLine();
        }
    }
}
