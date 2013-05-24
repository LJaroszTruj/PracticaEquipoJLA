using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace JLATeam
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//Para acceder a la BD de Liga
            Form2 v2 = new Form2();
            this.Hide();
            v2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {//Para acceder a la BD de Motorblog
            Form3 v3 = new Form3();
            this.Hide();
            v3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {//Para acceder a la BD de Ebanca
            Form4 v4 = new Form4();
            this.Hide();
            v4.Show();
        }
    }
}
