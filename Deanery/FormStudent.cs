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
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
            ShowStudent();
            ShowGroup();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxGroup.SelectedItem!=null && textBoxFirstName.Text!=""&& textBoxLastName.Text!="")
            {
                StudentSet student = new StudentSet();
                student.idGroup = Convert.ToInt32(comboBoxGroup.SelectedItem.ToString().Split('.')[0]);
                student.FirstName = textBoxFirstName.Text;
                student.LastName = textBoxLastName.Text;
                Program.dean.StudentSet.Add(student);
                Program.dean.SaveChanges();
                ShowStudent();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewStudent.SelectedItems.Count==1)
            {
                StudentSet student = listViewStudent.SelectedItems[0].Tag as StudentSet;
                student.idGroup = Convert.ToInt32(comboBoxGroup.SelectedItem.ToString().Split('.')[0]);
                student.FirstName = textBoxFirstName.Text;
                student.LastName = textBoxLastName.Text;
                Program.dean.SaveChanges();
                ShowStudent();
            }
        }

        private void listViewStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStudent.SelectedItems.Count==1)
            {
                StudentSet student = listViewStudent.SelectedItems[0].Tag as StudentSet;
                comboBoxGroup.SelectedIndex = comboBoxGroup.FindString(student.idGroup.ToString());
                textBoxFirstName.Text = student.FirstName;
                textBoxLastName.Text = student.LastName;
            }
            else
            {
                comboBoxGroup.SelectedItem = null;
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
            }
        }
        void ShowStudent()
        {
            listViewStudent.Items.Clear();
            foreach (StudentSet student in Program.dean.StudentSet)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    student.id.ToString(), student.FirstName, student.LastName, student.idGroup.ToString(),
                    student.GroupSet.NameGroup, student.GroupSet.Specialty
                });
                item.Tag = student;
                listViewStudent.Items.Add(item);
            }
        }
        void ShowGroup()
        {
            comboBoxGroup.Items.Clear();
            foreach (GroupSet groupSet in Program.dean.GroupSet)
            {
                string[] item = { groupSet.id.ToString() + ".", groupSet.NameGroup, groupSet.Specialty };
                comboBoxGroup.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewStudent.SelectedItems.Count==1)
                {
                    StudentSet student = listViewStudent.SelectedItems[0].Tag as StudentSet;
                    Program.dean.StudentSet.Remove(student);
                    Program.dean.SaveChanges();
                    ShowStudent();
                }
                comboBoxGroup.SelectedItem = null;
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
