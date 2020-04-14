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
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(':');
                    Notes temp = new Notes();
                    temp.note = values[1];                    
                    Notes.Note.Add(temp);
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
            rowcount = dgwNotes.CurrentRow.Index;
            for (int i = 0; i < Notes.Note.Count; i++)
            {
                if (dgwNotes.Rows.Count != 0 && rowcount != -1)
                {
                    if (Note[i].note == dgwNotes.Rows[rowcount].Cells[0].Value.ToString())
                    {
                        Note.RemoveAt(i);
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
    }
}
