using prelab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooplab
{
    public partial class Profile : Form
    {

        string file = @"Data\user.csv";
        //string base64photo;

        public Profile()
        {
            InitializeComponent();
        }

        //string base64photo;
        private void Profile_Load(object sender, EventArgs e)
        {
            dgwProfile.ColumnCount = 6;
            dgwProfile.Columns[0].Name = "Name";
            dgwProfile.Columns[1].Name = "Surname";
            dgwProfile.Columns[2].Name = "Phone Number";
            dgwProfile.Columns[3].Name = "Address";
            dgwProfile.Columns[4].Name = "E-mail";
            dgwProfile.Columns[5].Name = "Password";
            dgwProfile.AllowUserToDeleteRows = true;
            dgwProfile.AllowUserToAddRows = false;
            dgwProfile.Rows.Clear();

            //Save to List Userlist from user.csv
            //using (var reader = new StreamReader(file))
            //{
            //    while (!reader.EndOfStream)
            //    {
            //        var line = reader.ReadLine();
            //        var values = line.Split(';');

            //        User temp = new User();
            //        temp.Username = values[0];
            //        temp.Password = values[1];
            //        temp.Type = values[2];
            //        temp.Name = values[3];
            //        temp.Surname = values[4];
            //        temp.Phone_number = values[5];
            //        temp.Address = values[6];
            //        temp.E_mail = values[7];
            //        temp.Photo = values[8];
            //        users.Userlist.Add(temp);
            //    }
            //}

            //List from Profile List to dgwProfile
            using (var reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    Form1 form1 = new Form1();
                    string[] temp = { };
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    if (values[0] == prelab2.Form1.Loaduser.Username)
                    {
                        temp = new string[] { values[3], values[4], values[5], values[6], values[7], values[1] };
                        dgwProfile.Rows.Add(temp);
                        //display photo dgw
                        string base64String = values[8];

                        //users.Userlist[p].Photo = values[8];


                        byte[] imageBytes = Convert.FromBase64String(base64String);
                        // Convert byte[] to Image

                        using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                        {
                            pctPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                            if (base64String != "")
                            {
                                pctPhoto.Image = Image.FromStream(ms, true);
                            }
                        }
                    }
                }
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            int flag = 1;
            //string phone = users.Userlist[k_user].Phone_number;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            int ka=0;
            Match match = regex.Match(dgwProfile.Rows[0].Cells[4].Value.ToString());
            for (int k = 0; k < users.Userlist.Count; k++)
            {
                if (Form1.Loaduser.Username == users.Userlist[k].Username)
                {
                    ka = k;
                }
            }
            if ( users.Userlist[ka].Phone_number != dgwProfile.Rows[0].Cells[2].Value.ToString())
            {
                if (dgwProfile.Rows[0].Cells[2].Value.ToString().Length != 10)
                {
                    flag = 0;
                    lblError.Text = "Please enter 10 characters for Phone Number!";
                }
            }
            if (!match.Success && flag == 1)
            {
                flag = 0;
                lblError.Text = "E-mail is not correct";
            }
            if (flag == 1)
            {
                int j = 0;

                for (int k = 0; k < users.Userlist.Count; k++)
                {
                    if (Form1.Loaduser.Username == users.Userlist[k].Username)
                    {

                        //base64photo = users.Userlist[k_user].Photo;
                        //Save to Profile List from data grid view for update items
                        users.Userlist[k].Name = dgwProfile.Rows[j].Cells[0].Value.ToString(); //name
                        users.Userlist[k].Surname = dgwProfile.Rows[j].Cells[1].Value.ToString(); //surname
                        users.Userlist[k].Phone_number = dgwProfile.Rows[j].Cells[2].Value.ToString(); //phonenumber
                        users.Userlist[k].Address = dgwProfile.Rows[j].Cells[3].Value.ToString(); //address
                        users.Userlist[k].E_mail = dgwProfile.Rows[j].Cells[4].Value.ToString(); //email

                        if (users.Userlist[k].Password != dgwProfile.Rows[j].Cells[5].Value.ToString())
                        {
                            users.Userlist[k].Password = Hash256.ComputeSha256Hash(dgwProfile.Rows[j].Cells[5].Value.ToString()); //password
                        }
                        //using (var reader = new StreamReader(file))
                        //{
                        //    while (!reader.EndOfStream)
                        //    {
                        //        var line = reader.ReadLine();
                        //        var values = line.Split(';');
                        //        if (Form1.Loaduser.Username == values[0] && users.Userlist[k].Photo == values[8])
                        //        {
                        //            users.Userlist[k].Photo = values[8];
                        //        }
                        //    }
                        //}

                        //users.Userlist[k].Photo = base64photo; //photo
                        j++;
                    }
                }
                lblError.Text = "Success";
            }
            var userCSV = new StringBuilder();
            File.Delete(file);
            File.Create(file).Close();
            var newLine_ = "";
            for (int a = 0; a < users.Userlist.Count(); a++)
            {
                newLine_ = "";
                newLine_ = string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8}",
                users.Userlist[a].Username, users.Userlist[a].Password,
                users.Userlist[a].Type, users.Userlist[a].Name,
                users.Userlist[a].Surname, 
                String.Format("{0:(###) ### ## ##}", Convert.ToInt64(users.Userlist[a].Phone_number)),
                users.Userlist[a].Address, users.Userlist[a].E_mail,
                users.Userlist[a].Photo);
                userCSV.AppendLine(newLine_);
                File.AppendAllText(file, userCSV.ToString());
                userCSV.Clear();
            }
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pctPhoto.Image = new Bitmap(open.FileName);
                // image file path                
            }
            string base64photo;
            string path = open.FileName;
            if (path != "")
            {
                for (int k = 0; k < users.Userlist.Count; k++)
                {
                    if (Form1.Loaduser.Username == users.Userlist[k].Username)
                    {
                        byte[] imageArray = System.IO.File.ReadAllBytes(path);
                        string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                        base64photo = base64ImageRepresentation;
                        users.Userlist[k].Photo = base64photo;
                    }
                }
            }
        }
    }
}
