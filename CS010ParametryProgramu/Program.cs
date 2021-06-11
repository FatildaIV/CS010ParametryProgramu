using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS010ParametryProgramu
{
    class Program
    {
        static void JmenoVypis()
        {
            Console.Write("Karel");
        }
        static void Mezera()
        {
            Console.Write(" ");
        }
        static void PrijmeniVypis()
        {
            Console.Write("Hofman");
        }
        static void Vypis(string vypis)
        {
            Console.Write(vypis);
        }
        static void VypisJmenoPrijmeni()
        {
            JmenoVypis();
            Console.Write(" ");
            PrijmeniVypis();
        }
        static void VypisJmenoPrijmeni(string jmeno, string prijmeni)
        {
            Console.Write(jmeno);
            Console.Write(" ");
            Console.Write(prijmeni);
        }
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                VypisJmenoPrijmeni();
            }
            else if (args.Length == 2)
            {
                VypisJmenoPrijmeni(args[0], args[1]);
            }
            JmenoVypis();
            Mezera();
            PrijmeniVypis();
            Mezera();
            Vypis("2.D");
            Console.ReadKey();
        }
    }
}
