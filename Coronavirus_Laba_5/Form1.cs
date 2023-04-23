
using System.Runtime.InteropServices;

namespace Coronavirus_Laba_5
{
    public partial class Form1 : Form
    {
        Vaccination vaccination;
        public Form1()
        {
            
            InitializeComponent();
            AllocConsole();
            vaccination = new Vaccination();
            
            AllPacients.Items.AddRange(vaccination.GetPersons().ToArray());
            
            DoVaccineButton.Click += DoVaccineButton_Click;
            GetAllToVaccine.Click += GetAllToVaccine_Click;
            VaccineFirst.Click += VaccineFirst_Click;
            VaccineSecond.Click += VaccineSecond_Click;
            vaccination.Update += Vaccination_Update;
            
            
            
        }

        private void VaccineSecond_Click(object? sender, EventArgs e)
        {
            vaccination.GoToSecondVaccination();
        }

        private void VaccineFirst_Click(object? sender, EventArgs e)
        {
            vaccination.GoToFirstVaccination();
        }

        private void Vaccination_Update()
        {
            AllPacients.Items.Clear();
            
            AllPacients.Items.AddRange(vaccination.GetPersons().ToArray());
            
            OnVaccinationPaccients.Items.Clear();
            OnVaccinationPaccients.Items.AddRange(vaccination.GetFirstVaccPersons().ToArray());
            Sertificed.Items.Clear();
            Sertificed.Items.AddRange(vaccination.GetSecondVaccPersons().ToArray());
            AllPacients.Refresh();
            Sertificed.Refresh();
            OnVaccinationPaccients.Refresh();
        }

        private void GetAllToVaccine_Click(object? sender, EventArgs e)
        {
            vaccination.GoToVaccination();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        

        private void DoVaccineButton_Click(object sender, EventArgs e)
        {
            vaccination.Vaccinate();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}