using System;
using System.Collections.Generic;

namespace lists {
    class Program {
        static void Main (string[] args) {

            List<string> planetList = new List<string> () {
                "Mercury",
                "Mars"
            };

            planetList.Add ("Jupiter");
            planetList.Add ("Saturn");

            List<string> lastTwo = new List<string> () {
                "Uranus",
                "Neptune"
            };

            planetList.AddRange (lastTwo);

            planetList.Insert (1, "Venus");
            planetList.Insert (2, "Earth");

            planetList.Add ("Pluto");

            List<string> rockyPlanets = planetList.GetRange (0, 4);

            planetList.Remove ("Pluto");

            Dictionary<string, string> Cyborg = new Dictionary<string, string> () { 
                { "Mars", "Cyborg" },
            };
            Dictionary<string, string> Batman = new Dictionary<string, string> () { 
                { "Venus", "Batman" },
            };
            Dictionary<string, string> Superman = new Dictionary<string, string> () { 
                { "Earth", "Superman" },
            };
            Dictionary<string, string> WonderWoman = new Dictionary<string, string> () { 
                { "Mercury", "Wonder Woman" },
            };
            Dictionary<string, string> Flash = new Dictionary<string, string> () { 
                { "Jupiter", "Flash" },
            };
            Dictionary<string, string> GreenLantern = new Dictionary<string, string> () { 
                { "Saturn", "Green Lantern" },
            };
            Dictionary<string, string> AquaMan = new Dictionary<string, string> () { 
                { "Uranus", "AquaMan" },
            };
            Dictionary<string, string> Joker = new Dictionary<string, string> () { 
                { "Neptune", "Joker" }
            };

            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>> () {
                Cyborg,
                Batman,
                Superman,
                WonderWoman,
                Flash,
                GreenLantern,
                AquaMan,
                Joker
            };

            foreach (string planet in planetList) // iterate planets
            {
                List<string> matchingProbes = new List<string> ();

                foreach (Dictionary<string, string> probe in probes) // iterate probes
                {
                        if(probe.ContainsKey(planet))
                        {
                            matchingProbes.Add(probe[planet]);
                        }
                    /*
                        Does the current Dictionary contain the key of
                        the current planet? Investigate the ContainsKey()
                        method on a Dictionary.

                        If so, add the current spacecraft to `matchingProbes`.
                    */
                }
                string.Join("planetList", matchingProbes);

                /*
                    Use String.Join(",", matchingProbes) as part of the
                    solution to get the output below. It's the C# way of
                    writing `array.join(",")` in JavaScript.
                */
                Console.WriteLine ($"{planet}: {string.Join(", ", matchingProbes)}");
            }

        }
    }
}