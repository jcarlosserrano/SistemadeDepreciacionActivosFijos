using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace DEPRECIACION2._0
{
    public partial class BUSCAR_UBICACION : Form
    {
        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private String strCmd;
        private DataTable dt;
        private SqlDataAdapter sqlDa;
        private Boolean editando;

        public BUSCAR_UBICACION()
        {
            InitializeComponent();

            String instancia = "CORCHO";
            String bd = "sis325";

            try
            {
                sqlCon = new SqlConnection("Server=" + instancia + ";Database=" + bd + ";Trusted_Connection=True; MultipleActiveResultSets=true");
                sqlCon.Open();
                //MessageBox.Show("base de datos");
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo conectar con la base de datos");
                Application.Exit();
                //throw;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void buscar()
        {
            var query = "select * from ubicacion WHERE area='" + txtDescripcion.Text + "'";
            using (SqlCommand cmd = new SqlCommand(query, sqlCon))
            {
                SqlDataReader read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        lbCodRubro.Text = read["id_ubicacion"].ToString();
                        lbDescripcion.Text = read["area"].ToString();
                        txtDesc.Text = read["descripcionUbicacion"].ToString();
                        
                    }
                }
                else
                {
                    MessageBox.Show("no se encontro dicho rubro");
                    pnlDescripcion.Visible = false;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            buscar();
            pnlDescripcion.Visible = true;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
