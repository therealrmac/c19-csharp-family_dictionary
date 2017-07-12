using System;
using System.Collections.Generic;
using System.Linq;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){ 
                {"name", "Krista"},
                {"age", "42"}
            });
            foreach(var x in myFamily){
                Console.WriteLine($" {x.Value["name"]} is my {x.Key} and is {x.Value["age"]} ");

            }
        }
    }
}
