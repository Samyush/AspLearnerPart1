using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsloleAppCalculator
{
    public class APIdataFetcher
    {
        public APIdataFetcher(string name, string url)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}

//https://alialhaddad.medium.com/how-to-fetch-data-in-c-net-core-ea1ab720e3f9

//http://dummy.restapiexample.com/api/v1/employees