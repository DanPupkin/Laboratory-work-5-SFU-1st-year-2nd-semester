using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coronavirus_Laba_5
{
    
    public class Medician:IMedician
    {
        public delegate void PersonsListNotify();
        public  event IMedician.PersonsListNotify? Update;
        public List<IPerson> Vaccinepersons { get; set; } = new List<IPerson>();
        public List<IPerson> SecondVaccinepersons { get; set; } = new List<IPerson>();
        public List<IPerson> Persons { get; set; } = new List<IPerson>();
        public string Name { get; set; }

        public void AddPerson(IPerson person)
        {
            Persons.Add(person);
            Update?.Invoke();
        }

        public void GoToVaccine()
        {
            
            foreach (IPerson person in Persons.ToList())
            {
                if (person.VaccinationCount >= 2)
                {
                    SecondVaccinepersons.Add(person);
                    Persons.Remove(person);
                }
                else { 
                Vaccinepersons.Add(person);
                    Persons.Remove(person);
                }
            }
            Update?.Invoke();
        }
        public void GoToFirstVaccine()
        {
            foreach (IPerson person in Persons.ToList())
            {
                if (person.VaccinationCount == 0) { 
                Vaccinepersons.Add(person);
                    Persons.Remove(person);
                }
            }
            Update?.Invoke();
        }
        public void GoToSecondVaccine()
        {
            foreach (IPerson person in Persons.ToList())
            {
                if (person.VaccinationCount == 1)
                {
                    Vaccinepersons.Add(person);
                    Persons.Remove(person);
                }
            }
            Update?.Invoke();
        }
        public void DoVaccine()
        {
            Random rnd = new Random();
            foreach(IPerson person in Vaccinepersons.ToList())
            {
                if (rnd.NextDouble() > 0.5)
                {
                    person.VaccinationCount++;
                    Vaccinepersons.Remove(person);
                    
                    if (person.VaccinationCount >= 2)
                    {
                        SecondVaccinepersons.Add(person);
                        Persons.Remove(person);

                    }
                    else
                    {
                        Persons.Add(person);
                    }
                }
            }
            Update?.Invoke();
        }

    }
}
