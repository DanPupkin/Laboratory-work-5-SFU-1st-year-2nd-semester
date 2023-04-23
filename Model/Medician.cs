using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coronavirus_Laba_5
{
    
    public class Medician
    {
        public delegate void PersonsListNotify();
        public  event PersonsListNotify? Update;
        public List<Person> Vaccinepersons = new List<Person>();
        public List<Person> SecondVaccinepersons = new List<Person>();
        public List<Person> Persons = new List<Person>();
        public string Name { get; set; }

        public void AddPerson(Person person)
        {
            Persons.Add(person);
            Update.Invoke();
        }

        public void GoToVaccine()
        {
            
            foreach (Person person in Persons.ToList())
            {
                if (person.VaccitationCount >= 2)
                {
                    SecondVaccinepersons.Add(person);
                    Persons.Remove(person);
                }
                else { 
                Vaccinepersons.Add(person);
                    Persons.Remove(person);
                }
            }
            Update.Invoke();
        }
        public void GoToFirstVaccine()
        {
            foreach (Person person in Persons.ToList())
            {
                if (person.VaccitationCount == 0) { 
                Vaccinepersons.Add(person);
                    Persons.Remove(person);
                }
            }
            Update.Invoke();
        }
        public void GoToSecondVaccine()
        {
            foreach (Person person in Persons.ToList())
            {
                if (person.VaccitationCount == 1)
                {
                    Vaccinepersons.Add(person);
                    Persons.Remove(person);
                }
            }
            Update.Invoke();
        }
        public void DoVaccine()
        {
            Random rnd = new Random();
            foreach(Person person in Vaccinepersons.ToList())
            {
                if (rnd.NextDouble() > 0.5)
                {
                    person.VaccitationCount++;
                    Vaccinepersons.Remove(person);
                    
                    if (person.VaccitationCount >= 2)
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
            Update.Invoke();
        }

    }
}
