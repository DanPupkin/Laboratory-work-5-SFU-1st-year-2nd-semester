using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Cells;




namespace Coronavirus_Laba_5
{
    public class Vaccination
    {
        public delegate void VaccinationListNotify();
        public event VaccinationListNotify? Update;
        Medician Medcentr { get; set; }
        Workbook wb { get; set; }
        public Vaccination() 

        {
            Medcentr = new Medician() { Name = "Медцентр СФУ" };
            Medcentr.Update += Medcentr_Update;
            wb = new Workbook("C:\\Users\\arararagi\\source\\repos\\Coronavirus_Laba_5\\Logic\\pacients.xlsx");
            //Medcentr.Persons = new List<Person>();
            //wb.AbsolutePath = "C:\\Users\\arararagi\\source\\repos\\Coronavirus_Laba_5\\Logic\\pacients.xlsx";
            WorksheetCollection collection = wb.Worksheets;
            Worksheet worksheet = collection[0];
            int rows = worksheet.Cells.MaxDataRow+1;
            
            //int columns = worksheet.Cells.MaxDataColumn;



            for (int i = 0; i < rows; i++)
            {
                
                int VacCounter = Convert.ToInt32(worksheet.Cells[i, 0].Value);
                string PaccientName = Convert.ToString(worksheet.Cells[i, 1].Value);
                if (VacCounter!=null && PaccientName != null) 
                { 
                Person person = new Person(VacCounter, PaccientName);
                Medcentr.Persons.Add(person);
                }


            }
        
        }

        private void Medcentr_Update()
        {
            this.Update.Invoke();
        }

        public List<string> GetPersons()
        {
            List<string> list = new List<string>();
            foreach (Person pers in Medcentr.Persons)
            {
                list.Add($"[{pers.VaccitationCount}] {pers.Name}");
            }
            return list;
        }
        public List<string> GetFirstVaccPersons()
        {
            List<string> list = new List<string>();
            foreach (Person pers in Medcentr.Vaccinepersons)
            {
                list.Add($"[{pers.VaccitationCount}] {pers.Name}");
            }
            return list;
        }
        public List<string> GetSecondVaccPersons()
        {
            List<string> list = new List<string>();
            foreach (Person pers in Medcentr.SecondVaccinepersons)
            {
                list.Add($"[{pers.VaccitationCount}] {pers.Name}");
            }
            return list;
        }
        public void GoToVaccination()
        {
            Medcentr.GoToVaccine();
        }
        public void GoToFirstVaccination()
        {
            Medcentr.GoToFirstVaccine();
        }
        public void GoToSecondVaccination() 
        {
            Medcentr.GoToSecondVaccine();
        }
        public void Vaccinate()
        {
            Medcentr.DoVaccine();
        }


    }
}
