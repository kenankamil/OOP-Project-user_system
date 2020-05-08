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
        Stack<Func<object>> undoStack = new Stack<Func<object>>();
        Stack<Func<object>> redoStack = new Stack<Func<object>>();
        string file = @"Data\user.csv";
        int flag = 1; //control for edited items
        public Profile()
        {
            InitializeComponent();
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            dgwProfile.ColumnCount = 7;
            dgwProfile.Columns[0].Name = "Name";
            dgwProfile.Columns[1].Name = "Surname";
            dgwProfile.Columns[2].Name = "Phone Number";
            dgwProfile.Columns[3].Name = "Address";
            dgwProfile.Columns[4].Name = "E-mail";
            dgwProfile.Columns[5].Name = "Password";
            dgwProfile.Columns[6].Name = "Minimum Salary";
            dgwProfile.AllowUserToDeleteRows = true;
            dgwProfile.AllowUserToAddRows = false;
            dgwProfile.Rows.Clear();

            using (var reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    string[] temp = { };
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    if (values[0] == users.SelectedUser.Username)
                    {
                        temp = new string[] { values[3], values[4], values[5], values[6], values[7], values[1], values[9] };
                        dgwProfile.Rows.Add(temp);
                        //display photo dgw
                        string base64String = values[8];
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
            //string phone = users.Userlist[k_user].Phone_number;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            int ka=0;
            Match match = regex.Match(dgwProfile.Rows[0].Cells[4].Value.ToString());
            for (int k = 0; k < users.Userlist.Count; k++)
            {
                if (users.SelectedUser.Username == users.Userlist[k].Username)
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
                int flag1 = 0; //Control for changing minimum salary
                for (int k = 0; k < users.Userlist.Count; k++)
                {
                    if (users.SelectedUser.Username == users.Userlist[k].Username)
                    {
                        //Save to Profile List from data grid view for update items
                        users.Userlist[k].Name = dgwProfile.Rows[j].Cells[0].Value.ToString(); //name
                        users.Userlist[k].Surname = dgwProfile.Rows[j].Cells[1].Value.ToString(); //surname
                        if (users.Userlist[k].Phone_number != dgwProfile.Rows[j].Cells[2].Value.ToString())
                        {
                            users.Userlist[k].Phone_number = String.Format("{0:(###) ### ## ##}", Convert.ToInt64(dgwProfile.Rows[j].Cells[2].Value.ToString()));
                        }
                        else
                        {
                            users.Userlist[k].Phone_number = dgwProfile.Rows[j].Cells[2].Value.ToString(); //phonenumber
                        }
                        users.Userlist[k].Address = dgwProfile.Rows[j].Cells[3].Value.ToString(); //address
                        users.Userlist[k].E_mail = dgwProfile.Rows[j].Cells[4].Value.ToString(); //email

                        if (users.Userlist[k].Password != dgwProfile.Rows[j].Cells[5].Value.ToString())
                        {
                            users.Userlist[k].Password = Hash256.ComputeSha256Hash(dgwProfile.Rows[j].Cells[5].Value.ToString()); //password
                        }
                        if (users.Userlist[k].Minimum_salary != Convert.ToDouble(dgwProfile.Rows[j].Cells[6].Value))
                        {
                            lblError.Text = "Can't change minumum salary on this screen";
                            flag1 = 1; 
                        }
                        j++;
                    }
                }
                if(flag1==0)
                lblError.Text = "Success";
            }
            var userCSV = new StringBuilder();
            File.Delete(file);
            File.Create(file).Close();
            var newLine = "";
            for (int a = 0; a < users.Userlist.Count(); a++)
            {
                    newLine = "";
                    newLine = string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9}",
                    users.Userlist[a].Username, users.Userlist[a].Password,
                    users.Userlist[a].Type, users.Userlist[a].Name,
                    users.Userlist[a].Surname,
                    users.Userlist[a].Phone_number,
                    users.Userlist[a].Address, users.Userlist[a].E_mail,
                    users.Userlist[a].Photo,users.Userlist[a].Minimum_salary);
                    userCSV.AppendLine(newLine);
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
        private void btnPreviosPage_Click(object sender, EventArgs e)
        {
            if (Form1.Loaduser.Type == "Admin")
            {
                Admin goback = new Admin();
                this.Close();
                goback.Show();
            }
            else if (Form1.Loaduser.Type == "User")
            {
                UserForm goback = new UserForm();
                this.Close();
                goback.Show();
            }
            else
            {
                Part_time_User goback = new Part_time_User();
                this.Close();
                goback.Show();
            }
        }
        //protected override void OnKeyUp(KeyEventArgs e)
        //{
        //    //if (e.KeyCode == Keys.ControlKey && ModifierKeys == Keys.Control) { }
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        int currentRow = dgwProfile.CurrentRow.Index;
        //        if (currentRow >= 0)
        //            dgwProfile.CurrentCell = dgwProfile.Rows[currentRow].Cells[0];
        //    }
        //    base.OnKeyUp(e);
        //}
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey && ModifierKeys == Keys.Control) { }
            else if (e.KeyCode == Keys.Z && ModifierKeys == Keys.Control)
            {
                if (undoStack.Count > 0)
                {
                    StackPush(sender, redoStack);
                    undoStack.Pop()();
                }
            }
            else if (e.KeyCode == Keys.Y && ModifierKeys == Keys.Control)
            {
                if (redoStack.Count > 0)
                {
                    StackPush(sender, undoStack);
                    redoStack.Pop()();
                }
            }
            else
            {
                redoStack.Clear();
                StackPush(sender, undoStack);
            }
        }
        private void StackPush(object sender, Stack<Func<object>> stack)
        {
            TextBox textBox = (TextBox)sender;
            var tBT = textBox.Text(textBox.Text, textBox.SelectionStart);
            stack.Push(tBT);
        }
        private void lblminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really want to exit ?", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
        //If click the button where Calculate Salary is written, can enter and update minimum salary
        private void btnMinimumSalary_Click(object sender, EventArgs e)
        {
            SalaryCalculator salaryCalculator = new SalaryCalculator();
            this.Hide();
            salaryCalculator.Show();
        }
    }
}
public static class Extensions
{
    public static Func<TextBox> Text(this TextBox textBox, string text, int sel)
    {
        return () =>
        {
            textBox.Text = text;
            textBox.SelectionStart = sel;
            return textBox;
        };
    }
}
