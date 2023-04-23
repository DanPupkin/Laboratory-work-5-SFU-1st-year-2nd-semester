namespace Coronavirus_Laba_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.AllPacients = new System.Windows.Forms.ListBox();
            this.GetAllToVaccine = new System.Windows.Forms.Button();
            this.VaccineFirst = new System.Windows.Forms.Button();
            this.VaccineSecond = new System.Windows.Forms.Button();
            this.OnVaccinationPaccients = new System.Windows.Forms.ListBox();
            this.Sertificed = new System.Windows.Forms.ListBox();
            this.DoVaccineButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Все пациенты";
            // 
            // AllPacients
            // 
            this.AllPacients.FormattingEnabled = true;
            this.AllPacients.ItemHeight = 20;
            this.AllPacients.Location = new System.Drawing.Point(23, 119);
            this.AllPacients.Name = "AllPacients";
            this.AllPacients.Size = new System.Drawing.Size(374, 324);
            this.AllPacients.TabIndex = 1;
            // 
            // GetAllToVaccine
            // 
            this.GetAllToVaccine.Location = new System.Drawing.Point(403, 119);
            this.GetAllToVaccine.Name = "GetAllToVaccine";
            this.GetAllToVaccine.Size = new System.Drawing.Size(149, 84);
            this.GetAllToVaccine.TabIndex = 2;
            this.GetAllToVaccine.Text = "Отправить всех на вакцинацию";
            this.GetAllToVaccine.UseVisualStyleBackColor = true;
            // 
            // VaccineFirst
            // 
            this.VaccineFirst.Location = new System.Drawing.Point(403, 209);
            this.VaccineFirst.Name = "VaccineFirst";
            this.VaccineFirst.Size = new System.Drawing.Size(149, 84);
            this.VaccineFirst.TabIndex = 3;
            this.VaccineFirst.Text = "Отправить на первичную вакцинацию";
            this.VaccineFirst.UseVisualStyleBackColor = true;
            // 
            // VaccineSecond
            // 
            this.VaccineSecond.Location = new System.Drawing.Point(403, 299);
            this.VaccineSecond.Name = "VaccineSecond";
            this.VaccineSecond.Size = new System.Drawing.Size(149, 84);
            this.VaccineSecond.TabIndex = 4;
            this.VaccineSecond.Text = "Отправить на повторную вакцинацию";
            this.VaccineSecond.UseVisualStyleBackColor = true;
            // 
            // OnVaccinationPaccients
            // 
            this.OnVaccinationPaccients.FormattingEnabled = true;
            this.OnVaccinationPaccients.ItemHeight = 20;
            this.OnVaccinationPaccients.Location = new System.Drawing.Point(558, 119);
            this.OnVaccinationPaccients.Name = "OnVaccinationPaccients";
            this.OnVaccinationPaccients.Size = new System.Drawing.Size(358, 284);
            this.OnVaccinationPaccients.TabIndex = 5;
            // 
            // Sertificed
            // 
            this.Sertificed.FormattingEnabled = true;
            this.Sertificed.ItemHeight = 20;
            this.Sertificed.Location = new System.Drawing.Point(927, 119);
            this.Sertificed.Name = "Sertificed";
            this.Sertificed.Size = new System.Drawing.Size(322, 324);
            this.Sertificed.TabIndex = 6;
            // 
            // DoVaccineButton
            // 
            this.DoVaccineButton.Location = new System.Drawing.Point(558, 414);
            this.DoVaccineButton.Name = "DoVaccineButton";
            this.DoVaccineButton.Size = new System.Drawing.Size(358, 29);
            this.DoVaccineButton.TabIndex = 7;
            this.DoVaccineButton.Text = "Провести вакцинацию";
            this.DoVaccineButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пациенты на вакцинации";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(927, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Пациенты с сертификатом";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DoVaccineButton);
            this.Controls.Add(this.Sertificed);
            this.Controls.Add(this.OnVaccinationPaccients);
            this.Controls.Add(this.VaccineSecond);
            this.Controls.Add(this.VaccineFirst);
            this.Controls.Add(this.GetAllToVaccine);
            this.Controls.Add(this.AllPacients);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox AllPacients;
        private Button GetAllToVaccine;
        private Button VaccineFirst;
        private Button VaccineSecond;
        private ListBox OnVaccinationPaccients;
        private ListBox Sertificed;
        private Button DoVaccineButton;
        private Label label2;
        private Label label3;
    }
}