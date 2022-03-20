using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_assignment
{
    class Program
    {
        //Please write console app. User should be able to input hours and minutes of the analogue clock.
        //Program must calculate lesser angle in degrees between hours arrow and minutes arrow and provide
        //output in the console window.

        static void Main(string[] args)
        {
            double valanda;
            double minute;

            Console.WriteLine("Irasykite valanda");
            valanda = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Irasykite minutes");
            minute = Convert.ToDouble(Console.ReadLine());

            Program Kampo_apskaiciavimas = new Program();

            Kampo_apskaiciavimas.Apskaiciuoti_kampa(valanda, minute);

            Console.ReadKey();
        }

        void Apskaiciuoti_kampa (double valanda, double minute)
        {
            if (valanda > 12 || valanda < 0)
            {
                Console.WriteLine($"Iveskite valanda, kuri butu tarp 0 ir 12. " +
                    $"Jusu irasyta valanda {valanda} yra ivesta klaidingai.");
            }

            else if (minute > 60 || minute < 0)
            {
                Console.WriteLine($"Iveskite minute, kuri butu tarp 0 ir 60. " +
                    $"Jusu irasyta minute {minute} yra ivesta klaidingai.");
            }

            else if (valanda <= 12 || valanda >= 0 ||
                     minute <= 60 || minute >= 0)
            {
                double kampas_laipsniais_valanda = valanda * 30;
                double kampas_laipsniais_minute = minute * 6;

                double kampas = Math.Abs(kampas_laipsniais_valanda - kampas_laipsniais_minute);

                Console.WriteLine($"Kampo laipsnis tarp {valanda} valandos ir {minute} minutes yra: \n{kampas} lapsniu");
            }

            else

            {
                Console.WriteLine("Klaidingai ivesti duomenys");
            }
           
        }
    }
}
