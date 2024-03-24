using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashat_v01_
{
    public partial class سلف_العاملين : Form
    {
        public سلف_العاملين()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            القائمه_الرئيسيه home = new القائمه_الرئيسيه();
            home.Show();
            this.Close();
        }

        private void سلف_العاملين_Load(object sender, EventArgs e)
        {
            سلف_العاملين ancestor_of_employees = new سلف_العاملين();
            ancestor_of_employees.Show();
            this.Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            القائمه_الرئيسيه home = new القائمه_الرئيسيه();
            home.Show();
            this.Close();
        }
    }
}
