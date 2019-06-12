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
                MessageBox.Show("Please write in the content", "Warning",
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
                this.txtName.Focus();
            }
        }
    }
}
