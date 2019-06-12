using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        string strName;
        string strAge;
        string strWork;

        public Form1()
        {
            InitializeComponent();
        }

        bool TextCheck()
        {
            if(this.txtName.Text == "" || this.txtAge.Text == "" || this.txtWork.Text == "")
            {
                MessageBox.Show("Please enter all items.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtName.Focus();
                return false;
            }

            return true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(TextCheck())
            {
                this.strName = this.txtName.Text;
                this.strAge = this.txtAge.Text;
                this.strWork = this.txtWork.Text;

                ListViewItem lvi = new ListViewItem(
                    new string[] { strName, strAge, strWork }
                    );

                this.lvView.Items.Add(lvi);
                clearTextBox();

                this.txtName.Focus();
            }
        }

        private void clearTextBox()
        {
            this.txtName.Text = "";
            this.txtAge.Text = "";
            this.txtWork.Text = "";
        }

        private void LvView_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = this.lvView.SelectedItems[0]; // first item selected
            string name = lvi.SubItems[0].Text;
            string age = lvi.SubItems[1].Text;
            string work = lvi.SubItems[2].Text;

            MessageBox.Show("name : " + name + "\nage : " + age + "\nwork : " + work);
        }
    }
}
