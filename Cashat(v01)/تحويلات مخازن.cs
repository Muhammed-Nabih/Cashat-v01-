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
    public partial class تحويلات_مخازن : Form
    {
        public تحويلات_مخازن()
        {
            InitializeComponent();
        }

        private void تحويلات_مخازن_Load(object sender, EventArgs e)
        {

        }

       

        private void button7_Click_1(object sender, EventArgs e)
        {
            القائمه_الرئيسيه home = new القائمه_الرئيسيه();
            home.Show();
            this.Close();
        }
    }
}
