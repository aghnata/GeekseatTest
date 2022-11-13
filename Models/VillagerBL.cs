using System;
using System.Collections.Generic;
using System.Text;

namespace GeekseatTechnicalTest.Models
{
    public class VillagerBL
    {

        public List<int> GetPrimeNumb(int maxNumber)
        {
            var res = new List<int>();

            for (int i = 2; i <= maxNumber; i++)
            {
                if (i <= 2)
                {
                    res.Add(i);
                }
                else if (i <= 8)
                {
                    if (i % 2 != 0)
                    {
                        res.Add(i);
                    }
                }
                else
                {
                    if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                    {
                        res.Add(i);
                    }
                }
            }

            return res;
        }

        public int TotalKilled(int year)
        {
            int res = 2;
            var listPrimeNum = GetPrimeNumb(year*10);

            for (int i = 0; i < year-2; i++)
            {
                res += listPrimeNum[i];
            }

            return year == 1 ? year : res;
        }

        public void AverageKilled(decimal peopleNumber)
        {
            int total = 0;

            for (int i = 0; i < peopleNumber; i++)
            {

                Console.WriteLine($"Input Person - {i + 1}");
                Console.WriteLine("----------------------------------");

                Console.WriteLine("Input Age of Death:");
                var yearAge = int.Parse(Console.ReadLine());

                Console.WriteLine("Input Year of Death:");
                var yearDeath = int.Parse(Console.ReadLine());

                var diff = yearDeath - yearAge;

                if (diff < 0)
                {
                    total += -1;
                }
                else
                {
                    total += TotalKilled(diff);
                }
            }

            Console.WriteLine($"The average is: {total / peopleNumber}");

        }
    }
}
