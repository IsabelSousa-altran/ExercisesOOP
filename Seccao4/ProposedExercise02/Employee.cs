using System.Globalization;

namespace ProposedExercise02
{
    class Employee
    {
        public string Name;
        public double GrossSalary;
        public double Tax;

        public double RealSalary()
        {
            return GrossSalary - Tax;
        }

        public void IncreaseSalary(double percentage)
        {
            GrossSalary = GrossSalary + (GrossSalary * percentage / 100.0);
        }

        public override string ToString()
        {
            return Name
                + ", $ "
                + RealSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
