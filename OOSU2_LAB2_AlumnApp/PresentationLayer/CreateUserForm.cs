using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
            alumnRadioBtn.Checked = true;
        }

        private void CreateUserForm_Load(object sender, EventArgs e)
        {

        }

        private void alumnRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void adminRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void skapaKontoBtn_Click(object sender, EventArgs e)
        {
            if (alumnRadioBtn.Checked == true)
            {

            }
            else
            {

            }
        }
    }
}
