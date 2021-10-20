using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Data.OleDb;

namespace wareHouse
{
    public partial class FormLim2 : Form
    {
        string text = "Server=(local);Initial Catalog=wareHouse;Trusted_connection=Yes";
        object id_prod, prod, id_client, client;

        private void button1_Click(object sender, EventArgs e)
        {
            int bae;
            SqlConnection conn = new SqlConnection(text);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@code",tbx_id_prod.Text);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Цена FROM Товар WHERE Код_товара = @code";
            object result = cmd.ExecuteScalar();
            int a = Convert.ToInt32(result);
            conn.Close();
            if (bx_dost.SelectedIndex == 0)
            {
                bae = 2000;
                itog.Text = (Convert.ToInt32(count.Text) * a + bae).ToString();

            }
            if (bx_dost.SelectedIndex == 1)
            {
                bae = 1000;
                itog.Text = (Convert.ToInt32(count.Text) * a + bae).ToString();

            }
            if (bx_dost.SelectedIndex == 2)
            {
                bae = 500;
                itog.Text = (Convert.ToInt32(count.Text) * a + bae).ToString();

            }
            if (bx_dost.SelectedIndex == 3)
            {
                itog.Text = (Convert.ToInt32(count.Text) * a).ToString();

            }
            
        }

        public FormLim2(object id_prod, object prod, object id_client, object client)
        {
            InitializeComponent();
            this.id_prod = id_prod;
            this.prod = prod;
            this.id_client = id_client;
            this.client = client;
        }

        private void FormLim2_Load(object sender, EventArgs e)
        {

            string CommandText = "SELECT [Код_Сотрудника], [ФИО] FROM [Сотрудники] WHERE [Должность] like 'Менеджер по продажам'";
            SqlConnection conn = new SqlConnection(text);
            SqlDataAdapter da = new SqlDataAdapter(CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Поиск]");
            bx_empl.DataSource = ds.Tables["[Поиск]"].DefaultView;
  
            this.bx_empl.DisplayMember = "ФИО";
            this.bx_empl.ValueMember = "Код_Сотрудника";
            this.bx_empl.SelectedIndex = -1;

            FormLimited g = new FormLimited();
            tbx_id_prod.Text = this.id_prod.ToString();
            tbx_md.Text = this.prod.ToString();
            tbx_id_clients.Text = this.id_client.ToString();
            tbx_clients.Text = this.client.ToString();

        }
    }
}
