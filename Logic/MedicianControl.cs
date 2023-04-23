using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Coronavirus_Laba_5;

namespace Logic
{
    public static class MedicianControl
    {
        public static Medician MakeMedician(string Name)
        {
            return new Medician() { Name = Name };
        }
    }
}
