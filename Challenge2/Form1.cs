using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



namespace Challenge2
{
    public partial class Form1 : Form
    {
        SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Challenge2"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();            
        }


        ArrayList Sexo = new ArrayList();
        ArrayList Promedio = new ArrayList();
        ArrayList Edad = new ArrayList();
        ArrayList Periodo = new ArrayList();
        string[] lister = { "Edad", "Periodo" };

        private void Form1_Load(object sender, EventArgs e)  {

            ListLoader();
            MenuLoader();

            TotalLoader();

            Add_Menu.AllowDrop = true;

            BindDataTable("select * from Encuestas");

        }

        private void MenuLoader()
        {
            foreach (int item in Periodo)
            {
                SelPer.Items.Add(item.ToString().Insert(4, "/"));
                SelPer2.Items.Add(item.ToString().Insert(4, "/"));
            }
            foreach (int item in Edad)
            {
                SelAge.Items.Add(item);
            }
        }

        private void TotalLoader()
        {
            string query = "Promedio_Historico";
            string queryResp = "";
            SQL_Initializer(query);
            while (dr.Read())
            {
                queryResp = dr.GetInt32(0).ToString();
            }

            SQL_Closer();

            TotalProm.Text = queryResp;
        }

        private void ListLoader()

        {
            foreach (string item in lister)
            {
                string query = $"Promedio_x_{item}Tot";
                SQL_Initializer(query);
                while (dr.Read())
                {
                    if (item == "Periodo") Periodo.Add(dr.GetInt32(0)); 
                    
                    else if (item == "Edad") Edad.Add(dr.GetInt32(0));
                }

                SQL_Closer();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargador_Graficos();

        }

        private void Cargador_Graficos()
        {
            string opcion = comboBox1.Text;

            if (opcion == "Por sexo")
            {
                BindDataTable("exec Promedio_x_SexoTot");
                Grafico_Promedios_Sexo();
            }
            else if (opcion == "Por periodo")
            {
                BindDataTable("exec Promedio_x_PeriodoTot");
                Grafico_Promedios_Periodo();
            }
            else if (opcion == "Por edad")
            {
                BindDataTable("exec Promedio_x_EdadTot");
                Grafico_Promedios_Edad();
            }
            else if (opcion == "Por sexo y periodo")
            {
                ChartSelSex.Visible = true;
            }
        }

        private void ChartSelSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindDataTable($"Promedio_x_Sexo_y_Periodo3 {ChartSelSex.Text}");

            Grafico_Promedios_Sexo_Periodo();
        }
  
        private void Grafico_Promedios_Sexo()
        {
            ChartSelSex.Visible = false;
            Promedio.Clear();
            Sexo.Clear();
            string query = "Promedio_x_SexoTot";
            SQL_Initializer(query);

            while (dr.Read())
            {
                Sexo.Add(dr.GetString(0));
                Promedio.Add(dr.GetInt32(1));
            }

            SQL_Closer();
            ChartProm.Series[0].LegendText = "";
            ChartProm.Series[0].Points.DataBindXY(Sexo, Promedio);
            ChartProm.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
        }

        private void Grafico_Promedios_Periodo()
        {
            ChartSelSex.Visible = false;
            Promedio.Clear();
            Periodo.Clear();

            string query = "Promedio_x_PeriodoTot";
            SQL_Initializer(query);
            while (dr.Read())
            {
                Periodo.Add(dr.GetInt32(0).ToString().Insert(4, "/"));
                Promedio.Add(dr.GetInt32(1));
            }

            SQL_Closer();

            ChartProm.Series[0].Points.DataBindXY(Periodo, Promedio);
            ChartProm.Series[0].LegendText = "Evolucion\nde\nconsumo";
            ChartProm.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

        }
        private void Grafico_Promedios_Edad()
        {
            ChartSelSex.Visible = false;
            Edad.Clear();
            Promedio.Clear();

            string query = "Promedio_x_EdadTot";
            SQL_Initializer(query);
            while (dr.Read())
            {
                Edad.Add(dr.GetInt32(0).ToString());
                Promedio.Add(dr.GetInt32(1));
            }

            SQL_Closer();

            ChartProm.Series[0].LegendText = "Promedio\npor\nedad";
            ChartProm.Series[0].Points.DataBindXY(Edad, Promedio);
            ChartProm.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
        }
        private void Grafico_Promedios_Sexo_Periodo()
        {
            Periodo.Clear();
            Sexo.Clear();
            Promedio.Clear();

            var opcionSex = ChartSelSex.Text;

 
            string query = "Promedio_x_Sexo_y_Periodo3";
            cmd = new SqlCommand(query, Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Sexo", opcionSex);
            Conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Periodo.Add(dr.GetInt32(1).ToString().Insert(4, "/"));
                Promedio.Add(dr.GetInt32(2));
            }

            SQL_Closer();

            var generoWich = "";
            if (opcionSex == "M") generoWich = "Hombres";
            else if (opcionSex == "F") generoWich = "Mujeres";
            else generoWich = "Otros";
    
            ChartProm.Series[0].LegendText = $"Promedio\npor {generoWich}";
            ChartProm.Series[0].Points.DataBindXY(Periodo, Promedio);
            ChartProm.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void SQL_Initializer(string query)
        {
            cmd = new SqlCommand(query, Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();
        }
        private void SQL_Closer()
        {
            dr.Close();
            Conexion.Close();
        }

        private void SelSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargador_PromxSex();
        }

        private void Cargador_PromxSex()
        {
            var opcion = SelSex.Text;
            var fuente = "Sexo";

            txtSexo.Text = Load_Proms(opcion, fuente);
        }

        private void SelPer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargador_Periodo();

        }

        private void Cargador_Periodo()
        {
            var opcion = SelPer.Text;
            var opciona = string.Join("", opcion.Split('/'));
            Convert.ToInt32(opciona);
            var fuente = "Periodo";
            txtPeriodo.Text = Load_Proms(opciona, fuente);
        }

        private void SelAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargador_Edad();
        }

        private void Cargador_Edad()
        {
            var opcion = SelAge.Text;
            var fuente = "Edad";

            txtEdad.Text = Load_Proms(opcion, fuente);
        }

        private string Load_Proms(string opcion, string source, string opcion2="", string source2="")
        { 
            string query = $"Promedio_x_{source}{source2}";
            var resultQ = "";


            cmd = new SqlCommand(query, Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue($"@{source}", opcion);
            if(opcion2 != "") { 
                source2 = "Periodo"; 
                cmd.Parameters.AddWithValue($"@{source2}", opcion2); 
            }
            Conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (opcion2 != "")
                {
                    resultQ = dr.GetInt32(2).ToString();
                }
                else    resultQ = dr.GetInt32(1).ToString();
            }

            SQL_Closer();

            return resultQ;

        }

        private void SelSex2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBridge();
        }
        private void SelPer2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBridge();
                    
        }

        private void LoadBridge()
        {
            if (SelSex2.Text != "Sexo" && SelPer2.Text != "Periodo")
            {
                var opcion = SelSex2.Text;
                var fuente = "Sexo";
                var opcion2 = SelPer2.Text;
                var opciona = string.Join("", opcion2.Split('/'));
                Convert.ToInt32(opciona);
                var fuente2 = "_y_Periodo";
                txtSexoPeriodo.Text = Load_Proms(opcion,fuente, opciona, fuente2);
            }
            
        }

        private void BindDataTable(string query)
        {
            Conexion.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, Conexion);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GralTable.DataSource= dt;
            Conexion.Close();

        }

        private void Rst_Table_Click(object sender, EventArgs e)
        {
            BindDataTable("select * from Encuestas");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Menu.Visible = true;
        }



        private void BtnAdd_Click(object sender, EventArgs e)
        {

            Periodo.Clear();
            Sexo.Clear();
            Promedio.Clear();
            Edad.Clear();

            string query = "Add_Encuesta";



            try
            {
                var FechaNacimientoN = AddNacimiento.Value;

                char SexoN;
                if (RbM.Checked) SexoN = 'M';
                else if (RbF.Checked) SexoN = 'F';
                else SexoN = 'O';

                int PeriodoU;


                int CantidadPeliculas = Convert.ToInt32(NumPelis.Value);

                var User = new Usuario();

                PeriodoU = Convert.ToInt32(AddAño.Text + AddMes.Text);

                User.FechaNacimiento = FechaNacimientoN;
                User.Sexo = SexoN;
                User.Periodo = PeriodoU;
                User.CantidadPeliculas = CantidadPeliculas;

                cmd = new SqlCommand(query, Conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaNacimiento", User.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Sexo", User.Sexo);
                cmd.Parameters.AddWithValue("@Periodo", User.Periodo);
                cmd.Parameters.AddWithValue("@CantidadPeliculas", User.CantidadPeliculas);
                Conexion.Open();
                dr = cmd.ExecuteReader();
                SQL_Closer();

                ListLoader();
                MenuLoader();
                TotalLoader();
                if (comboBox1.Text != "Promedio peliculas") Cargador_Graficos();
                if (SelSex.Text != "Sexo") Cargador_PromxSex();
                if (SelPer.Text != "Periodo") Cargador_Periodo();
                if (SelAge.Text != "Edad") Cargador_Edad();
                LoadBridge();
                BindDataTable("select * from Encuestas");

                Add_Menu.Visible = false;
            }
            catch
            {
                MessageBox.Show("Ingresar un periodo valido (MM / AAAA)");
            }


        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Add_Menu.Visible = false;
        }
    }


}