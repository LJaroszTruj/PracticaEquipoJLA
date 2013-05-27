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
    public partial class Form2 : Form
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
        
        public Form2()
        {
            InitializeComponent();
            try
            {
                cadenaConexion = "Server = localhost; Database = liga; Uid = root; Pwd = ; Port = 3306;";
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();

            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 v1 = new Form1();
            this.Hide();
            v1.Show();
        }

        private void accede_equipo_Click(object sender, EventArgs e)
        {//Pulsar para acceder a la pantalla de Equipo
            //Enseña los botones de equipo
            consulta1E.Show();
            consulta2E.Show();
            consulta3E.Show();
            consulta4E.Show();
            //Retira los botones de jugadores
            consulta1J.Hide();
            consulta2J.Hide();
            consulta3J.Hide();
            consulta4J.Hide();
            consulta5J.Hide();
            consulta6J.Hide();
            //Retira los botones de partidos
            consulta1P.Hide();
            consulta2P.Hide();
            consulta3P.Hide();
            consulta4P.Hide();
            consulta5P.Hide();
            consulta6P.Hide();
        }

        private void accede_jugadores_Click(object sender, EventArgs e)
        {//Pulsar para acceder a la pantalla de Jugadores
            //Enseña los botones de jugadores
            consulta1J.Show();
            consulta2J.Show();
            consulta3J.Show();
            consulta4J.Show();
            consulta5J.Show();
            consulta6J.Show();
            //Retira los botones de equipos
            consulta1E.Hide();
            consulta2E.Hide();
            consulta3E.Hide();
            consulta4E.Hide();
            //Retira los botones de partidos
            consulta1P.Hide();
            consulta2P.Hide();
            consulta3P.Hide();
            consulta4P.Hide();
            consulta5P.Hide();
            consulta6P.Hide();
        }

        private void accede_partido_Click(object sender, EventArgs e)
        {//Pulsar para acceder a la pantalla de Partidos
            //Enseña los botones de partidos
            consulta1P.Show();
            consulta2P.Show();
            consulta3P.Show();
            consulta4P.Show();
            consulta5P.Show();
            consulta6P.Show();
            //Retira los botones de equipos
            consulta1E.Hide();
            consulta2E.Hide();
            consulta3E.Hide();
            consulta4E.Hide();
            //Retira los botones de jugadores
            consulta1J.Hide();
            consulta2J.Hide();
            consulta3J.Hide();
            consulta4J.Hide();
            consulta5J.Hide();
            consulta6J.Hide();
        }

        private void consulta1J_Click(object sender, EventArgs e)
        {//Jugadores de la liga
            
        }

        private void consulta2J_Click(object sender, EventArgs e)
        {//Jugador con más salario

        }

        private void consulta3J_Click(object sender, EventArgs e)
        {//Jugador con menos salario

        }

        private void consulta4J_Click(object sender, EventArgs e)
        {//Jugador más alto

        }

        private void consulta5J_Click(object sender, EventArgs e)
        {//Jugador más bajo

        }

        private void consulta6J_Click(object sender, EventArgs e)
        {//Nº de jugadores que juegan en cada equipo

        }

        private void consulta1P_Click(object sender, EventArgs e)
        {//Partidos jugados

        }

        private void consulta2P_Click(object sender, EventArgs e)
        {//Mayor resultado en local

        }

        private void consulta3P_Click(object sender, EventArgs e)
        {//Mayor resultado en visitante

        }

        private void consulta4P_Click(object sender, EventArgs e)
        {//Menor resultado en local

        }

        private void consulta5P_Click(object sender, EventArgs e)
        {//Equipo jugador más local

        }

        private void consulta6P_Click(object sender, EventArgs e)
        {//Equipo jugador más visitante

        }

        private void consulta1E_Click(object sender, EventArgs e)
        {//Equipos que juegan
            conexion.Open();

            sentenciaSQL = "SELECT nombre, ciudad, web, puntos FROM equipos;";
            comando = new MySqlCommand(sentenciaSQL, conexion);
            resultado = comando.ExecuteReader();

            while(resultado.Read()){
                label1.Text += resultado.GetString(sentenciaSQL + "/t");
            }

            conexion.Close();
        }

        private void consulta2E_Click(object sender, EventArgs e)
        {//Equipo con más puntos

        }

        private void consulta3E_Click(object sender, EventArgs e)
        {//Equipo con menos puntos

        }

        private void consulta4E_Click(object sender, EventArgs e)
        {//Webs de los equipos

        }

    }
}
