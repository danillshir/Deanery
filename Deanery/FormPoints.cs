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
    public partial class FormPoints : Form
    {
        public FormPoints()
        {
            InitializeComponent();
            ShowPoint();
            ShowSubject();
            ShowStudent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSubject.SelectedItem != null && comboBoxStudent.SelectedItem != null && textBoxPoint.Text != "")
                {
                    PointSet point = new PointSet();
                    point.idSubject = Convert.ToInt32(comboBoxSubject.SelectedItem.ToString().Split('.')[0]);
                    point.idStudent = Convert.ToInt32(comboBoxStudent.SelectedItem.ToString().Split('.')[0]);
                    point.Point = Convert.ToInt32(textBoxPoint.Text);
                    Program.dean.PointSet.Add(point);
                    Program.dean.SaveChanges();
                    ShowPoint();
                }
            }
            catch
            {
                MessageBox.Show("Невозможно добавить, введите другие значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ShowPoint()
        {
            listViewPoints.Items.Clear();
            foreach (PointSet point in Program.dean.PointSet)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    point.idSubject.ToString(), point.SubjectSet.NameSubject, point.idStudent.ToString(),
                    point.StudentSet.LastName +" "+ point.StudentSet.FirstName, point.Point.ToString()
                });
                item.Tag = point;
                listViewPoints.Items.Add(item);
            }
        }

        private void listViewPoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPoints.SelectedItems.Count == 1)
            {
                PointSet point = listViewPoints.SelectedItems[0].Tag as PointSet;
                comboBoxSubject.SelectedIndex = comboBoxSubject.FindString(point.idSubject.ToString());
                comboBoxStudent.SelectedIndex = comboBoxStudent.FindString(point.idStudent.ToString());
                textBoxPoint.Text = point.Point.ToString();
            }
            else
            {
                comboBoxSubject.SelectedItem = null;
                comboBoxStudent.SelectedItem = null;
                textBoxPoint.Text = "";
            }
        }
        void ShowSubject()
        {
            comboBoxSubject.Items.Clear();
            foreach (SubjectSet subjectSet in Program.dean.SubjectSet)
            {
                string[] item = { subjectSet.id.ToString() + ".", subjectSet.NameSubject};
                comboBoxSubject.Items.Add(string.Join(" ", item));
            }
        }
        void ShowStudent()
        {
            comboBoxStudent.Items.Clear();
            foreach (StudentSet studentSet in Program.dean.StudentSet)
            {
                string[] item = { studentSet.id.ToString() + ".", studentSet.LastName, studentSet.FirstName };
                comboBoxStudent.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewPoints.SelectedItems.Count == 1)
            {
                PointSet point = listViewPoints.SelectedItems[0].Tag as PointSet;
                point.idSubject = Convert.ToInt32(comboBoxSubject.SelectedItem.ToString().Split('.')[0]);
                point.idStudent = Convert.ToInt32(comboBoxStudent.SelectedItem.ToString().Split('.')[0]);
                point.Point = Convert.ToInt32(textBoxPoint.Text);
                Program.dean.SaveChanges();
                ShowPoint();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPoints.SelectedItems.Count == 1)
                {
                    PointSet point = listViewPoints.SelectedItems[0].Tag as PointSet;
                    Program.dean.PointSet.Remove(point);
                    Program.dean.SaveChanges();
                    ShowPoint();
                }
                comboBoxSubject.SelectedItem = null;
                comboBoxStudent.SelectedItem = null;
                textBoxPoint.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
