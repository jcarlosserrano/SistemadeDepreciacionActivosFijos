using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DEPRECIACION2._0
{
    public partial class DEPRECIACION : Form
    {
        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private String strCmd;
        private DataTable dt;
        private SqlDataAdapter sqlDa;
        private Boolean editando;
        private DataTable dt1;
        private DataTable dt2;
        private DataTable dt3;

        public DEPRECIACION()
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




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void actualizarTabla()
        {
            dt = new DataTable();
            strCmd = "select * from depreciacion";
            sqlCmd = new SqlCommand(strCmd, sqlCon);
            sqlDa = new SqlDataAdapter(sqlCmd);
            sqlDa.Fill(dt);
            //dgvRubro.DataSource = dt;

        }

        private void actualizarTabla1()
        {
            dt2 = new DataTable();
            strCmd = "select * from recursosHumanos";
            sqlCmd = new SqlCommand(strCmd, sqlCon);
            sqlDa = new SqlDataAdapter(sqlCmd);
            sqlDa.Fill(dt2);
            //dgvRubro.DataSource = dt;

        }

      /*  public void recuperarCampos()
        {
            var query = "select activoFijo.DESCRIPCION,activoFijo.VALOR_COMPRA,activoFijo.FECHA_COMPRA, rubro.Porc_DEPRECIACION, registro.InicioUFV,registro.finalUFV from activoFijo inner join registro on  registro.idActivoFijo=activoFijo.ID_ACTIVO inner join rubro on rubro.id_rubro=activoFijo.ID_RUBRO";
            using (SqlCommand cmd = new SqlCommand(query, sqlCon))
            {
                SqlDataReader read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        label5.Text = read["DESCRIPCION"].ToString();
                        label3.Text = read["VALOR_COMPRA"].ToString();
                        label4.Text = read["FECHA_COMPRA"].ToString();
                        label1.Text = read["Porc_DEPRECIACION"].ToString();
                        label2.Text = read["InicioUFV"].ToString();
                        label6.Text = read["finalUFV"].ToString();

                    }
                    
                }
                else
                {
                    throw new Exception("NO SE ENCONTRO EL DETERMINADO ACTIVO");
                }
            }
   
        }*/


      

        private void DEPRECIACION_Load(object sender, EventArgs e)
        {
            actualizarTabla();
            //recuperarCampos();
            dataGridView1.DataSource = dt;
            
        }

        private void idActivoFijoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
