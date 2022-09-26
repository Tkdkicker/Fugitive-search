using System.Runtime.CompilerServices;

namespace Fugitive_search
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fugitiveLicencePlates = new List<string();
            string licencePlate;
            fugitiveLicencePlates.Add("X999GHP");
            fugitiveLicencePlates.Add("BD51MSR");
            fugitiveLicencePlates.Add("PR0SPER");

            licencePlate = Console.ReadLine();
            if (fugitiveLicencePlates.Contains(licencePlate))
            {
                Console.WriteLine("This car may be driven by a wanted fugitive");
            }
            else
            {
                Console.WriteLine("This person is noty suspicious");
            }
        }
    }
}