using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coronavirus_Laba_5
{
    public class Person:IPerson
    {
        public string Name { get; set; }
        public int VaccinationCount { get; set; } = 0;
        public Person (int counter, string name)
        {
            this.Name = name;
            this.VaccinationCount = counter;
        }

    }
}
