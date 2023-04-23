using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
     public interface IMedician
    {
        public delegate void PersonsListNotify();
        public event PersonsListNotify? Update;


        public List<IPerson> Vaccinepersons { get; set; }
        public List<IPerson> SecondVaccinepersons { get; set; }
        public List<IPerson> Persons { get; set; }
        string Name { get; }
        void AddPerson(IPerson person);
        void GoToVaccine();
        void GoToFirstVaccine();

        void GoToSecondVaccine();
        void DoVaccine();
    }
}
