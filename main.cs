using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the amount:");

        string input = Console.ReadLine();

        if (decimal.TryParse(input, out decimal amount))
        {
            string person = aP(amount);
            if (person != null)
            {
                Console.WriteLine($"{person} is found in Php {amount}.");
            }
            else
            {
                Console.WriteLine($"Invalid Denomination: {amount}.");
            }
        }
    }

    static string aP(decimal amount)
    {
        switch (amount)
        {
            case 0.01m:
            case 0.05m:
            case 0.25m:
                return "No Person";
            case 1:
                return "Jose Rizal";
            case 5:
                return "Emilio Aguinaldo";
            case 10:
                return "Andres Bonifacio & Apolinario Mabini";
            case 20:
                return "Manuel L. Quezon";
            case 50:
                return "Sergio Osmeña";
            case 100:
                return "Manuel Roxas";
            case 200:
                return "Diosdado Macapagal";
            case 500:
                return "Benigno Aquino Sr. & Corazon Aquino";
            case 1000:
                return "Jose Abad Santos, Vicente Lim & Josefa Llanes Escoda";
            default:
                return null;
        }
    }
}
