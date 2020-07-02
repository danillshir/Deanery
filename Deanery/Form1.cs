using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deanery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            Form formGroup = new FormGroup();
            formGroup.Show();
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            Form formStudent = new FormStudent();
            formStudent.Show();
        }

        private void buttonSubject_Click(object sender, EventArgs e)
        {
            Form formSubject = new FormSubject();
            formSubject.Show();
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            Form formPoints = new FormPoints();
            formPoints.Show();
        }
    }
}
