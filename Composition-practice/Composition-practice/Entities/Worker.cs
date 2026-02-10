using Composition_practice.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Composition_practice.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public Double BaseSalary { get; set; }

        public void AddContract(HourContract[] contract)
        {
            for (int i = 0; i < contract.Length; i++)
            {
                Console.WriteLine($"----------DATA FROM CONTRACT {i + 1}----------");
                Console.WriteLine();

                Console.WriteLine("Insert Date:");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Insert value to Hour:");
                Double valueToHour = Double.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Insert hours working:");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine();

                contract[i] = new HourContract()
                {
                    Date = date,
                    ValueToHour = valueToHour,
                    Hours = hours
                };
            }
        }

        public void RemoveContract(HourContract contract)
        {

        }

        public Double Income (int year, int month)
        {
            return 0;
        }
    }
}
