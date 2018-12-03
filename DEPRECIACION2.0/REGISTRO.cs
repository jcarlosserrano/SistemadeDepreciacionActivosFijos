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
    public partial class REGISTRO : Form
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


        public REGISTRO()
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



        private void actualizarTabla()
        {
            dt = new DataTable();
            strCmd = "select * from registro";
            sqlCmd = new SqlCommand(strCmd, sqlCon);
            sqlDa = new SqlDataAdapter(sqlCmd);
            sqlDa.Fill(dt);
            //dgvRubro.DataSource = dt;

        }

        private void actualizarTabla1()
        {
            dt1 = new DataTable();
            strCmd = "select * from activoFijo";
            sqlCmd = new SqlCommand(strCmd, sqlCon);
            sqlDa = new SqlDataAdapter(sqlCmd);
            sqlDa.Fill(dt1);
            //dgvRubro.DataSource = dt;

        }

        private void actualizarTabla2()
        {
            dt2 = new DataTable();
            strCmd = "select * from recursosHumanos";
            sqlCmd = new SqlCommand(strCmd, sqlCon);
            sqlDa = new SqlDataAdapter(sqlCmd);
            sqlDa.Fill(dt2);
            //dgvRubro.DataSource = dt;

        }

        private void actualizarTabla3()
        {
            dt3 = new DataTable();
            strCmd = "select * from ubicacion";
            sqlCmd = new SqlCommand(strCmd, sqlCon);
            sqlDa = new SqlDataAdapter(sqlCmd);
            sqlDa.Fill(dt3);
            //dgvRubro.DataSource = dt;

        }

        private void REGISTRO_Load(object sender, EventArgs e)
        {
           
            actualizarTabla();
            registroDataGridView.DataSource = dt;
            actualizarTabla1();
            idActivoFijoComboBox.DisplayMember = "CODIGO_ACTIVO";
            idActivoFijoComboBox.ValueMember = "CODIGO_ACTIVO";
            
            idActivoFijoComboBox.DataSource = dt1;
            actualizarTabla2();
            idPersonalComboBox.DisplayMember = "CiPersonal";
            idPersonalComboBox.ValueMember = "CiPersonal";
            idPersonalComboBox.DataSource = dt2;
            actualizarTabla3();
            idUbicacionComboBox.DisplayMember = "area";
            idUbicacionComboBox.ValueMember = "area";
            idUbicacionComboBox.DataSource = dt3;
        }



        string respuesta;
        public string SeleccionaIdArea()
        {
            var query = "select id_ubicacion from ubicacion where area='" + idUbicacionComboBox.Text + "'";
            using (SqlCommand cmd = new SqlCommand(query, sqlCon))
            {
                SqlDataReader read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        respuesta = read["id_ubicacion"].ToString();
                    }
                    return respuesta;
                }
                else
                {
                    throw new Exception("NO SE ENCONTRO EL DETERMINADO ACTIVO");
                }
            }
        }

        

        private void idUbicacionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = SeleccionaIdArea();

            DateTime fechahoy = new DateTime();
            fechahoy = DateTime.Today;
            label2.Text = fechahoy.ToShortDateString();

        }

       // string respuesta1;
        public string SeleccionaIdPersonal()
        {
            var query = "select idCliente from recursosHumanos where CiPersonal='" + idPersonalComboBox.Text + "'";
            using (SqlCommand cmd = new SqlCommand(query, sqlCon))
            {
                SqlDataReader read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        respuesta = read["idCliente"].ToString();
                    }
                    return respuesta;
                }
                else
                {
                    throw new Exception("NO SE ENCONTRO EL DETERMINADO ACTIVO");
                }
            }
        }

        private void idPersonalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = SeleccionaIdPersonal();
        }

        public string SeleccionaIdActivo()
        {
            var query = "select ID_ACTIVO from activoFijo where CODIGO_ACTIVO='" + idActivoFijoComboBox.Text + "'";
            using (SqlCommand cmd = new SqlCommand(query, sqlCon))
            {
                SqlDataReader read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        respuesta = read["ID_ACTIVO"].ToString();
                    }
                    return respuesta;
                }
                else
                {
                    throw new Exception("NO SE ENCONTRO EL DETERMINADO ACTIVO");
                }
            }
        }


        private void idActivoFijoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = SeleccionaIdActivo();
        }



        private Boolean camposCompletos()
        {
            if (inicioUFVTextBox.Text.Equals("") || finalUFVTextBox.Text.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private Boolean guardar()
        {
            try
            {

                //if (txtDescripcion.Equals("")){
                strCmd = "insert into registro(idActivoFijo,idPersonal,idUbicacion,fechaRegistro,InicioUFV,finalUFV) VALUES (" + label5.Text + "," + label3.Text + "," + label4.Text + ",'" + label2.Text + "','" + inicioUFVTextBox.Text + "','" + finalUFVTextBox.Text + "')";
                sqlCmd = new SqlCommand(strCmd, sqlCon);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRO INSTERADA EXITOSAMENTE", "Aviso");
                return true;
                //}
                //else
                //    MessageBox.Show("error");
                //        return (SqlException)

                //sqlCon.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show(label5.Text + label3.Text + label4.Text);
                MessageBox.Show("no se inserto", "advertencia");
                return false;
                // throw;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (camposCompletos())
            {
                guardar();
                actualizarTabla();
                registroDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("VERIFIQUE TODOS LOS CAMPOS DEBEN ESTAR CORRECTOS");
            }
        }

        private void inicioUFVTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 abrir = new Form1();
            abrir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ACTIVOS abrir = new ACTIVOS();
            abrir.Show();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            recursosHumanos abrir = new recursosHumanos();
            abrir.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UBICACION abrir = new UBICACION();
            abrir.Show();
        }
    }
}
