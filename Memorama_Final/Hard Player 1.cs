using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorama_Final
{
    public partial class Hard_Player_1 : Form
    {
        public Hard_Player_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ir = new Dificultad();
            ir.Show();
            this.Hide();
        }

        private void Hard_Player_1_Load(object sender, EventArgs e)
        {

        }
    }
}
