using System;
using System.Collections.Generic;
using Composition.Entities.Enums;

namespace Composition.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> listContracts { get; private set; } = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            listContracts = new List<HourContract>();
        }

        public void AddContract(HourContract contract)
        {
            listContracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            listContracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach ( HourContract contract in listContracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
                
            }
            return sum;
        }
    }
}
