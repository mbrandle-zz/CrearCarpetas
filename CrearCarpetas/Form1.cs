using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CrearCarpetas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ofdBuscarExcel = new OpenFileDialog();
                ofdBuscarExcel.Filter = "Archivos Excel|*.xls;*.xlsx;*.xlsm";
                //ofdBuscarExcel.ShowDialog();
                if (ofdBuscarExcel.ShowDialog() == DialogResult.OK)
                {

                    txtArchivo.Text = ofdBuscarExcel.FileName;
                    string con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+ofdBuscarExcel.FileName+";"+@"Extended Properties='Excel 8.0;HDR=Yes;'";
                    using (OleDbConnection connection = new OleDbConnection(con))
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand("select * from [Hoja1$]", connection);
                        using (OleDbDataReader dr = command.ExecuteReader())
                        {
                            int celdas = 0;
                            while (dr.Read())
                            {
                                var row1Col0 = dr[0];
                                //Console.WriteLine(row1Col0);
                                dgObras.Rows[0].Cells[celdas].Value = row1Col0;
                                celdas++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //dgObras = new DataGridView();
            /*int celdas=dgObras.RowCount;
            dgObras.Rows[0].Cells[celdas].Value="000000";*/
        }
    }
}
