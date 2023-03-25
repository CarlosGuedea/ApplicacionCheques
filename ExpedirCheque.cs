using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlChequesRev2
{
    public partial class ExpedirCheque : Form
    {
        public int estado;
        public ExpedirCheque()
        {
            InitializeComponent();
            estado = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            estado -= 1;
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Folio = this.Folio.Text;
            string dia = dateTimePicker1.Value.ToString("dd");
            string mes = dateTimePicker1.Value.ToString("MM");
            string anio = dateTimePicker1.Value.ToString("yyyy");
            string Fecha = "'" + anio + "-" + mes + "-" + dia + "'";
            string Nombre = this.Nombre.Text;
            string Monto = this.Monto.Text;
            string Detalle = this.Detalle.Text;
            PrincipalMenu principalMenu = new PrincipalMenu();
            this.Close();



            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");


                //Crear la consulta
                String Sql = "Insert into Cheque (Folio, Beneficiario, Monto, Fecha_Emision, Detalle) values (" + Folio + ",'" + Nombre + "'," + Monto + "," + Fecha + ",'" + Detalle + "')";
                SqlCommand command = new SqlCommand(Sql, conexion);
                command.CommandType = System.Data.CommandType.Text;
                conexion.Open();

                //Ejecutar la consulta
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error no se pudo conectar a la base de datos");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
