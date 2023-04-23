using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IVaccination
    {
        public delegate void VaccinationListNotify();
        public event VaccinationListNotify? Update;
        IMedician Medcentr { get; set; }

        void Medcentr_Update();


        List<string> GetPersons();

        List<string> GetFirstVaccPersons();

        List<string> GetSecondVaccPersons();

        void GoToVaccination();

        void GoToFirstVaccination();
        void GoToSecondVaccination();

        void Vaccinate();


    }
}
