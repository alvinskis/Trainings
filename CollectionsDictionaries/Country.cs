using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsDictionaries
{
    class Country
    {
        //Add Auto-Implemented Properties

        public string Name { get; }
        public string Code { get; }
        public string Continent { get; }
        public int Population { get; }

        //Add class constructor with parameters
        public Country(string name, string code, string continent, int population)
        {
            //Use this keyword to refer to class fields
            this.Name = name;
            this.Code = code;
            this.Continent = continent;
            this.Population = population;
        }

    }
}
