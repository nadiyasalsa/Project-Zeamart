using MySql.Data.MySqlClient;
using Mysqlx.Session;
using System.Data;

namespace Project_Zeamart
{
    public partial class Form1 : Form
    {
        int i = 0;

        MySqlConnection koneksi = connections.getConnection();
        DataTable dataTable = new DataTable();

        public Form1()
        {

            InitializeComponent();
        }

        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(koneksi, "SET @id := 0; UPDATE sepatu SET id = @id := (@id+1); " +
                "ALTER TABLE sepatu AUTO_INCREMENT = 1;");

            script.Execute();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldataTable();
        }

        public DataTable getDataSepatu()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM sepatu", koneksi))
            {
                koneksi.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;

        }

        public void filldataTable()
        {
            dataGridView1.DataSource = getDataSepatu();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}