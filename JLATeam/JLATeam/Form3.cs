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
    public partial class Form3 : Form
    {
        //La línea que guarda la IP del servidor MySql, el usuario y la pass
        String cadenaConexion;

        //Conector que almacena la conexión a la BBDD
        MySqlConnection conexion;

        //Comando que quiero que se ejecute
        MySqlCommand comando;

        //Consulta
        String sentenciaSQL;

        //Resultado de la consulta
        MySqlDataReader resultado;

        public Form3()
        {
            InitializeComponent();

            try
            {
                cadenaConexion = "Server = localhost; Database = liga; Uid = root; Pwd = ; Port = 3306;";
                conexion = new MySqlConnection(cadenaConexion);


            }
            catch (Exception) { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 v1 = new Form1();
            this.Hide();
            v1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
            }
            catch(Exception) { }
        }
    }
}
