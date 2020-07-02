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
    public partial class FormGroup : Form
    {
        public FormGroup()
        {
            InitializeComponent();
            ShowGroup();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            GroupSet groupSet = new GroupSet();
            groupSet.NameGroup = textBoxNameGroup.Text;
            groupSet.Specialty = textBoxSpecialty.Text;
            groupSet.Year = Convert.ToInt32(textBoxYear.Text);
            Program.dean.GroupSet.Add(groupSet);
            Program.dean.SaveChanges();
            ShowGroup();
        }
        void ShowGroup()
        {
            listViewGroup.Items.Clear();
            foreach (GroupSet groupSet in Program.dean.GroupSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    groupSet.id.ToString(), groupSet.NameGroup, groupSet.Specialty, groupSet.Year.ToString()
                }
                    );
                item.Tag = groupSet;
                listViewGroup.Items.Add(item);
            }
            listViewGroup.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewGroup.SelectedItems.Count ==1)
            {
                GroupSet groupSet = listViewGroup.SelectedItems[0].Tag as GroupSet;
                groupSet.NameGroup = textBoxNameGroup.Text;
                groupSet.Specialty = textBoxSpecialty.Text;
                groupSet.Year = Convert.ToInt32(textBoxYear.Text);
                Program.dean.SaveChanges();
                ShowGroup();
            }
        }

        private void listViewGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewGroup.SelectedItems.Count==1)
            {
                GroupSet groupSet = listViewGroup.SelectedItems[0].Tag as GroupSet;
                textBoxNameGroup.Text = groupSet.NameGroup;
                textBoxSpecialty.Text = groupSet.Specialty;
                textBoxYear.Text = groupSet.Year.ToString();
            }
            else
            {
                textBoxNameGroup.Text = "";
                textBoxSpecialty.Text = "";
                textBoxYear.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewGroup.SelectedItems.Count==1)
                {
                    GroupSet groupSet = listViewGroup.SelectedItems[0].Tag as GroupSet;
                    Program.dean.GroupSet.Remove(groupSet);
                    Program.dean.SaveChanges();
                    ShowGroup();
                }
                textBoxNameGroup.Text = "";
                textBoxSpecialty.Text = "";
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
