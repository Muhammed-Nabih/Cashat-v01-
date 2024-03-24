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
    public partial class التقارير : Form
    {
        public التقارير()
        {
            InitializeComponent();
        }

        private void التقارير_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            القائمه_الرئيسيه home = new القائمه_الرئيسيه();
            home.Show();
            this.Close();
        }
    }
}
