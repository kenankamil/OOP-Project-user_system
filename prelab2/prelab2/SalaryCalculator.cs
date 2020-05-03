using prelab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooplab
{
    public partial class SalaryCalculator : Form
    {
        public SalaryCalculator()
        {
            InitializeComponent();
        }
        int baz_ücret = 5500;
        private void SalaryCalculator_Load(object sender, EventArgs e)
        {
            cmbExperience.Items.Add("2-4");
            cmbExperience.Items.Add("5-9");
            cmbExperience.Items.Add("10-14");
            cmbExperience.Items.Add("15-20");
            cmbExperience.Items.Add("over 20 years ");
            cmbCity.Items.Add("İstanbul");
            cmbCity.Items.Add("Ankara");
            cmbCity.Items.Add("İzmir");
            cmbCity.Items.Add("Kocaeli, Sakarya, Düzce, Bolu, Yalova");
            cmbCity.Items.Add("Edirne, Kırklareli, Tekirdağ ");
            cmbCity.Items.Add("Trabzon, Ordu, Giresun, Rize, Artvin, Gümüşhane");
            cmbCity.Items.Add("Bursa, Eskişehir, Bilecik ");
            cmbCity.Items.Add("Aydın, Denizli, Muğla");
            cmbCity.Items.Add("Adana, Mersin");
            cmbCity.Items.Add("Balıkesir, Çanakkale");
            cmbCity.Items.Add("Antalya, Isparta, Burdur ");
            cmbCity.Items.Add("Others");
            cmbEducation.Items.Add("Meslek alanı ile ilgili yüksek lisans");
            cmbEducation.Items.Add("Meslek alanı ile ilgili doktora");
            cmbEducation.Items.Add("Meslek alanı ile ilgili doçentlik");
            cmbEducation.Items.Add("Meslek alanı ile ilgili olmayan yüksek lisans");
            cmbEducation.Items.Add("Meslek alanı ile ilgili olmayan doktora/doçentlik");
            cmbForeignLanguage.Items.Add("Belgelendirilmiş İngilizce bilgisi");
            cmbForeignLanguage.Items.Add("İngilizce eğitim veren okul mezuniyeti");
            cmbForeignLanguage.Items.Add("Belgelendirilmiş diğer yabancı dil bilgisi (her dil için)");
            cmbManagementTask.Items.Add("Takım Lideri");
            cmbManagementTask.Items.Add("Grup Yöneticisi");
            cmbManagementTask.Items.Add("Teknik Yönetici");
            cmbManagementTask.Items.Add("Yazılım Mimarı");
            cmbManagementTask.Items.Add("Proje Yöneticisi");
            cmbManagementTask.Items.Add("Direktör");
            cmbManagementTask.Items.Add("Projeler Yöneticisi");
            cmbManagementTask.Items.Add("CTO");
            cmbManagementTask.Items.Add("Genel Müdür");
            cmbManagementTask.Items.Add("Bilgi İşlem Sorumlusu(Bilgi İşlem biriminde en çok 5 bilişim personeli varsa)");
            cmbManagementTask.Items.Add("Bilgi İşlem Müdürü(Bilgi İşlem biriminde en çok 5 bilişim personeli varsa)");
            cmbManagementTask.Items.Add("Bilgi İşlem Sorumlusu(Bilgi İşlem biriminde 5'ten çok bilişim personeli varsa)");
            cmbManagementTask.Items.Add("Bilgi İşlem Müdürü(Bilgi İşlem biriminde 5'ten çok bilişim personeli varsa)");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int i;
            for (i=0; i < users.Userlist.Count; i++)
            {
                if (users.SelectedUser.Username == users.Userlist[i].Username)
                {
                    break;
                }
            }
            users.Userlist[i].Minimum_salary = 0;
            if (cmbExperience.SelectedIndex == 0)
                users.Userlist[i].Minimum_salary += 0.6;
            else if (cmbExperience.SelectedIndex == 1)
                users.Userlist[i].Minimum_salary += 1.0;
            else if (cmbExperience.SelectedIndex == 2)
                users.Userlist[i].Minimum_salary += 1.20;
            else if (cmbExperience.SelectedIndex == 3)
                users.Userlist[i].Minimum_salary += 1.35;
            else if (cmbExperience.SelectedIndex == 4)
                users.Userlist[i].Minimum_salary += 1.5;
            if (cmbCity.SelectedIndex == 0)
                users.Userlist[i].Minimum_salary += 0.15;
            else if (cmbCity.SelectedIndex == 1)
                users.Userlist[i].Minimum_salary += 0.1;
            else if (cmbCity.SelectedIndex == 2)
                users.Userlist[i].Minimum_salary += 0.1;
            else if (cmbCity.SelectedIndex == 3)
                users.Userlist[i].Minimum_salary += 0.05;
            else if (cmbCity.SelectedIndex == 4)
                users.Userlist[i].Minimum_salary += 0.05;
            else if (cmbCity.SelectedIndex == 5)
                users.Userlist[i].Minimum_salary += 0.03;
            else if (cmbCity.SelectedIndex == 6)
                users.Userlist[i].Minimum_salary += 0.03;
            else if (cmbCity.SelectedIndex == 7)
                users.Userlist[i].Minimum_salary += 0.03;
            else if (cmbCity.SelectedIndex == 8)
                users.Userlist[i].Minimum_salary += 0.03;
            else if (cmbCity.SelectedIndex == 9)
                users.Userlist[i].Minimum_salary += 0.03;
            else if (cmbCity.SelectedIndex == 10)
                users.Userlist[i].Minimum_salary += 0.03;
            if (cmbEducation.SelectedIndex == 0)
                users.Userlist[i].Minimum_salary += 0.1;
            else if (cmbEducation.SelectedIndex == 1)
                users.Userlist[i].Minimum_salary += 0.3;
            else if (cmbEducation.SelectedIndex == 2)
                users.Userlist[i].Minimum_salary += 0.35;
            else if (cmbEducation.SelectedIndex == 3)
                users.Userlist[i].Minimum_salary += 0.05;
            else if (cmbEducation.SelectedIndex == 4)
                users.Userlist[i].Minimum_salary += 0.15;
            if (cmbForeignLanguage.SelectedIndex == 0)
                users.Userlist[i].Minimum_salary += 0.2;
            else if (cmbForeignLanguage.SelectedIndex == 1)
                users.Userlist[i].Minimum_salary += 0.2;
            else if (cmbForeignLanguage.SelectedIndex == 2)
                users.Userlist[i].Minimum_salary += 0.05;
            if (cmbManagementTask.SelectedIndex == 0)
                users.Userlist[i].Minimum_salary += 0.5;
            else if (cmbManagementTask.SelectedIndex == 1)
                users.Userlist[i].Minimum_salary += 0.5;
            else if (cmbManagementTask.SelectedIndex == 2)
                users.Userlist[i].Minimum_salary += 0.75;
            else if (cmbManagementTask.SelectedIndex == 3)
                users.Userlist[i].Minimum_salary += 0.85;
            else if (cmbManagementTask.SelectedIndex == 4)
                users.Userlist[i].Minimum_salary += 0.85;
            else if (cmbManagementTask.SelectedIndex == 5)
                users.Userlist[i].Minimum_salary += 1.0;
            else if (cmbManagementTask.SelectedIndex == 6)
                users.Userlist[i].Minimum_salary += 1.0;
            else if (cmbManagementTask.SelectedIndex == 7)
                users.Userlist[i].Minimum_salary += 0.4;
            else if (cmbManagementTask.SelectedIndex == 8)
                users.Userlist[i].Minimum_salary += 0.4;
            else if (cmbManagementTask.SelectedIndex == 9)
                users.Userlist[i].Minimum_salary += 0.6;
            else if (cmbManagementTask.SelectedIndex == 10)
                users.Userlist[i].Minimum_salary += 0.6;
            if (chbpartner.Checked)
                users.Userlist[i].Minimum_salary += 0.2;
            if (chb0_6.Checked)
                users.Userlist[i].Minimum_salary += 0.2;
            if (chb7_18.Checked)
                users.Userlist[i].Minimum_salary += 0.3;
            if (chb18_.Checked)
                users.Userlist[i].Minimum_salary += 0.4;

            users.Userlist[i].Minimum_salary += 1;
            users.Userlist[i].Minimum_salary *= baz_ücret;
            if (users.Userlist[i].Type == "Part-time User")
                users.Userlist[i].Minimum_salary /= 2;
          
                var csv = new StringBuilder();
                string fileName = @"Data\user.csv";
            File.WriteAllText(fileName, "");
                for (int j = 0; j < users.Userlist.Count; j++)
                {
                var newLine = string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9}",
                        users.Userlist[j].Username, users.Userlist[j].Password,
                        users.Userlist[j].Type, users.Userlist[j].Name, users.Userlist[j].Surname,
                        users.Userlist[j].Phone_number,
                        users.Userlist[j].Address, users.Userlist[j].E_mail, users.Userlist[j].Photo,users.Userlist[j].Minimum_salary);
                        csv.AppendLine(newLine);                    
                }
                File.AppendAllText(@"Data\user.csv", csv.ToString());
            lblsalary.Text = users.Userlist[i].Minimum_salary.ToString();
        }
    }
}
