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
    public partial class Notes : Form
    {
        private string filenamenotes = @"Data\notes.csv";
        private string note;
        private static List<Notes> notes = new List<Notes>();
        private static List<string> notesLoadUser = new List<string>();
        private static List<string> notesUpdate = new List<string>();
        bool firstClick = true;
        public Notes()
        {
            InitializeComponent();
        }
        public static List<Notes> Note { get => notes; set => notes = value; }
        private void Notes_Load(object sender, EventArgs e)
        {
            if (!File.Exists(filenamenotes))
            {
                File.Create(filenamenotes).Close();
            }
            dgwNotes.ColumnCount = 1;
            dgwNotes.Columns[0].Name = "Notes";
            dgwNotes.AllowUserToDeleteRows = true;
            dgwNotes.AllowUserToAddRows = false;
            using (var reader = new StreamReader(filenamenotes))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var value = line.Split(':');
                    Notes temp = new Notes();
                    temp.note = value[1];
                    Notes.Note.Add(temp);
                    notesUpdate.Add(value[1]);
                    notesLoadUser.Add(value[0]);
                }
            }
        }
        private void BtnCreatNote_Click(object sender, EventArgs e)
        {
            if (txtNewNote.Text == "")
            {
                lblmassage.Text = "You did not write anything!";
            }
            else
            {
                Notes notes = new Notes();
                var csv = new StringBuilder();
                var newLine = Form1.Loaduser.Username + ":" + txtNewNote.Text;
                csv.AppendLine(newLine);
                File.AppendAllText(filenamenotes, csv.ToString());
                lblmassage.Text = "Success";
            }
            using (var reader = new StreamReader(filenamenotes))
            {
                Note.Clear();
                notesLoadUser.Clear();
                notesUpdate.Clear();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(':');
                    Notes temp = new Notes();
                    temp.note = values[1];
                    Notes.Note.Add(temp);
                    notesLoadUser.Add(values[0]);
                    notesUpdate.Add(values[1]);
                }
            }
        }
        private void BtnList_Click(object sender, EventArgs e)
        {
            dgwNotes.Rows.Clear();
            //List the Notes of own user
            using (var reader = new StreamReader(filenamenotes))
            {
                while (!reader.EndOfStream)
                {
                    string[] temp = { };
                    var line = reader.ReadLine();
                    var values = line.Split(':');                    
                    if (values[0] == Form1.Loaduser.Username)
                    {
                        temp = new string[] { values[1] };
                        dgwNotes.Rows.Add(temp);                      
                    }
                }
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Delete the selected row
            int rowcount = -1;
            if (dgwNotes.CurrentRow != null)
            {
                rowcount = dgwNotes.CurrentRow.Index;
            }
            else
            {
                MessageBox.Show("You must choose a note!", "ERROR");
            }
            for (int i = 0; i < Notes.Note.Count; i++)
            {
                if (dgwNotes.Rows.Count != 0 && rowcount != -1)
                {
                    if (Note[i].note == dgwNotes.Rows[rowcount].Cells[0].Value.ToString())
                    {
                        Note.RemoveAt(i);
                        notesLoadUser.RemoveAt(i);
                        notesUpdate.RemoveAt(i);
                        File.WriteAllText(filenamenotes, "");
                        for (int j = 0; j < Note.Count; j++)
                        {
                            var csv = new StringBuilder();
                            var newLine = Form1.Loaduser.Username + ":" + Note[j].note.ToString();
                            csv.AppendLine(newLine);
                            File.AppendAllText(filenamenotes, csv.ToString());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You must choose a note!", "ERROR");
                    break;
                }
            }
        }
        private void lblclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lblminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void txtNewNote_Click(object sender, EventArgs e)
        {
            if (firstClick)
            {
                txtNewNote.Text = string.Empty;
                firstClick = false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int j = 0;
            for (int k = 0; k < notesUpdate.Count; k++) //Update notesUptade list from dgwNotes
            {               
                if (Form1.Loaduser.Username == notesLoadUser[k]) 
                {
                    notesUpdate[k] = dgwNotes.Rows[j].Cells[0].Value.ToString();
                    j++;
                }
            }
            //Rewrite to notes.csv
            var notesCsv = new StringBuilder();
            File.Delete(filenamenotes);
            File.Create(filenamenotes).Close();
            var newLine_ = "";
            for (int k = 0; k <notesUpdate.Count; k++)
            {
                newLine_ = "";
                newLine_ =string.Format(notesLoadUser[k]+":"+ notesUpdate[k]) ;
                notesCsv.AppendLine(newLine_);
                File.AppendAllText(@"Data\notes.csv", notesCsv.ToString());
                notesCsv.Clear();
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
    }
}
