using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3304Session1
{
    public partial class FishyNotes : Form
    {
        //Declairing a Form, call it'_newNote', which will store an instance for a note
        Form _newNote;

        public FishyNotes()
        {
            InitializeComponent();
        }

        private void AddNote_Click(object sender, EventArgs e)
        {
            if(_newNote == null)
            {
                _newNote = new FishyNote.FishyNote();
                _newNote.Show();
            }
        }
    }
}
