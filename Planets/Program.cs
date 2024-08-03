using System;
using PlanetLibrary;

namespace Planets
{
    class Program
    {
                
        static void Main(string[] args)
        {
            //Application.Run(new Form1());

            Planet[] planetArray = new Planet[10];

            planetArray[0] = new Planet("Mercury", 57.9, 88, 4878);
            planetArray[1] = new Planet("Venus", 108.9, 224.7, 12104);
            planetArray[2] = new Planet("Earth", 149.6, 365.26, 12756);
            planetArray[3] = new Planet("Mars", 227.9, 687, 6794);
            planetArray[4] = new Planet("Jupiter", 778.3, 4331.98, 142800);
            planetArray[5] = new Planet("Saturn", 1427, 10760.56, 120000);
            planetArray[6] = new Planet("Uranus", 2870, 30685.5, 52000);
            planetArray[7] = new Planet("Neptune", 4497, 60194.85, 48400);
            planetArray[8] = new Planet("Pluto", 5900, 90474.9, 2302);

            planetArray[9] = new Planet("JupiterTwin", 778.3, 4331.98, 142800);


            for (int t = 0; t <= 90; t = t + 15)
            {
                foreach (Planet p in planetArray)
                {
                    Console.WriteLine("x = " + Convert.ToString(p.getPosition(t).X)
                + " y = " + Convert.ToString(p.getPosition(t).Y));
                }

                Console.WriteLine("---------------------");
            }

            Console.WriteLine(planetArray[4].Name + " == " + planetArray[8].Name);
            Console.WriteLine(planetArray[4] == planetArray[8] ? "True" : "False");

            Console.WriteLine(planetArray[4].Name + " == " + planetArray[9].Name);
            Console.WriteLine(planetArray[4] == planetArray[9] ? "True" : "False");

            Console.WriteLine(planetArray[4].Name + " != " + planetArray[3].Name);
            Console.WriteLine(planetArray[4] != planetArray[8] ? "True" : "False");

            Console.WriteLine(planetArray[4].Name + " .Equals " + planetArray[3].Name);
            Console.WriteLine(planetArray[4].Equals(planetArray[8]) ? "True" : "False");

            Console.WriteLine(planetArray[4].Name + " > " + planetArray[3].Name);
            Console.WriteLine(planetArray[4] > planetArray[8] ? "True" : "False");

            Console.WriteLine(planetArray[4].Name + " < " + planetArray[3].Name);
            Console.WriteLine(planetArray[4] < planetArray[8] ? "True" : "False");



            Console.WriteLine("Imploding");
            Console.WriteLine("Neptune diameter" + planetArray[7].EquatorialDiameterkm);
            planetArray[7] = Planet.Implode(planetArray[7]);
            Console.WriteLine("Neptune diameter" + planetArray[7].EquatorialDiameterkm);

            Console.WriteLine("Saturn diameter" + planetArray[6].EquatorialDiameterkm);
            planetArray[6] = planetArray[6].Implode();
            Console.WriteLine("Neptune diameter" + planetArray[6].EquatorialDiameterkm);


            Console.Read();

        }
    }
}
