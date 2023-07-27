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
    public partial class Dificultad : Form
    {
        public Dificultad()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ir = new Hard_Player_1();
            ir.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ir = new Player_1();
            ir.Show();
            this.Hide();
        }
    }
}
