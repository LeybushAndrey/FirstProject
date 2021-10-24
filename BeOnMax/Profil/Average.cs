using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profil
{
    class Average
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваши фамилия и имя?");
            string FullName = Console.ReadLine();

            Console.WriteLine("Ваш возраст?");
            int Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Ваш вес в кг?");
            double Weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Ваш рост в метрах?");
            double Height = double.Parse(Console.ReadLine());

            double BodyMassIndex = Weight / (Height * Height);

            Console.WriteLine($"Your profile:\nFull Name:{FullName}\nAge:{Age}\nWeight:{Weight}\nHeight:{Height}\nBody Mass Index:{BodyMassIndex}");
        }
    }
}
