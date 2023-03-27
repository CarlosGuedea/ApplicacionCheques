using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlChequesRev2
{
    public partial class ResultadoCheques : Form
    {
        public ResultadoCheques()
        {
            InitializeComponent();
            llenarFilas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResultadoCheques_Load(object sender, EventArgs e)
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Liberar recursos y eliminar instancia del formulario
            this.Dispose();
            Reportes reportes = new Reportes();
            reportes.Show();
        }

        private void llenarFilas()
        {
            try
            {
                //Conección a la base de datos
                SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Cheques;User=usuario;Password=12345;Trusted_Connection=True;");


                //Crear la consulta
                String Sql = "Select * from Cheque";
                SqlCommand command = new SqlCommand(Sql, conexion);
                command.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader;
                conexion.Open();

                //Ejecutar la consulta
                reader = command.ExecuteReader();

                //Limpiamos los campos
                dataGridView1.Rows.Clear();

                //Recorremos el objeto reader
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["Folio"].ToString(), reader["Beneficiario"].ToString(), reader["Monto"].ToString(), reader["Fecha_Emision"].ToString(), reader["Detalle"].ToString());
                }

                //Hacemos la verificación de las credenciales

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error no se pudo conectar a la base de datos");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            // Establecer la impresora predeterminada en "Microsoft Print to PDF"
            printDialog.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            // Mostrar el cuadro de diálogo de impresión
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Crear una instancia del controlador de impresión
                PrintDocument printDocument = new PrintDocument();

                // Establecer el nombre del documento a imprimir
                printDocument.DocumentName = "MiDocumento";

                // Asignar la configuración de impresora seleccionada al controlador de impresión
                printDocument.PrinterSettings = printDialog.PrinterSettings;

                // Asignar el controlador de impresión al evento PrintPage para generar la salida
                printDocument.PrintPage += new PrintPageEventHandler(PrintPage);

                // Imprimir el documento en un archivo PDF
                printDocument.Print();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Crear un objeto Bitmap del tamaño de la vista actual
            Bitmap bitmap = new Bitmap(this.Width, this.Height);

            // Dibujar la vista actual en el objeto Bitmap
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));

            // Dibujar el objeto Bitmap en la página de impresión
            e.Graphics.DrawImage(bitmap, new Rectangle(0, 0, e.PageBounds.Width, e.PageBounds.Height));
        }
    }
}
