using GeekseatTechnicalTest.Models;
using System;

namespace GeekseatTechnicalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new VillagerBL();

            Console.WriteLine("Welcome... ");

            Console.WriteLine("Input number of villagers: ");
            decimal villagerNumber = decimal.Parse(Console.ReadLine());

            v.AverageKilled(villagerNumber);
        }
    }
}
