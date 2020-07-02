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
    public partial class FormSubject : Form
    {
        public FormSubject()
        {
            InitializeComponent();
            ShowSubject();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SubjectSet subjectSet = new SubjectSet();
                subjectSet.NameSubject = textBoxName.Text;
                subjectSet.Teacher = textBoxTeacher.Text;
                subjectSet.Semester = Convert.ToInt32(textBoxSemester.Text);
                subjectSet.Year = Convert.ToInt32(textBoxYear.Text);
                Program.dean.SubjectSet.Add(subjectSet);
                Program.dean.SaveChanges();
                ShowSubject();
            }
            catch
            {
                MessageBox.Show("Невозможно добавить, введите другие значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ShowSubject()
        {
            listViewSubject.Items.Clear();
            foreach (SubjectSet subjectSet in Program.dean.SubjectSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    subjectSet.id.ToString(), subjectSet.NameSubject, subjectSet.Teacher, 
                    subjectSet.Semester.ToString(), subjectSet.Year.ToString()
                }
                    );
                item.Tag = subjectSet;
                listViewSubject.Items.Add(item);
            }
            listViewSubject.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSubject.SelectedItems.Count == 1)
            {
                SubjectSet subjectSet = listViewSubject.SelectedItems[0].Tag as SubjectSet;
                subjectSet.NameSubject = textBoxName.Text;
                subjectSet.Teacher = textBoxTeacher.Text;
                subjectSet.Semester = Convert.ToInt32(textBoxSemester.Text);
                subjectSet.Year = Convert.ToInt32(textBoxYear.Text);
                Program.dean.SaveChanges();
                ShowSubject();
            }
        }

        private void listViewSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSubject.SelectedItems.Count == 1)
            {
                SubjectSet subjectSet = listViewSubject.SelectedItems[0].Tag as SubjectSet;
                textBoxName.Text = subjectSet.NameSubject;
                textBoxTeacher.Text = subjectSet.Teacher;
                textBoxSemester.Text = subjectSet.Semester.ToString();
                textBoxYear.Text = subjectSet.Year.ToString();
            }
            else
            {
                textBoxName.Text = "";
                textBoxTeacher.Text = "";
                textBoxSemester.Text = "";
                textBoxYear.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSubject.SelectedItems.Count == 1)
                {
                    SubjectSet subjectSet = listViewSubject.SelectedItems[0].Tag as SubjectSet;
                    Program.dean.SubjectSet.Remove(subjectSet);
                    Program.dean.SaveChanges();
                    ShowSubject();
                }
                textBoxName.Text = "";
                textBoxTeacher.Text = "";
                textBoxSemester.Text = "";
                textBoxYear.Text = "";
            }
            //При ошибке
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
