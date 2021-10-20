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
    public partial class AddPost : Form
    {
        public AddPost()
        {
            InitializeComponent();
        }
        string text = "Server=(local);Initial Catalog=wareHouse;Trusted_connection=Yes";
        private void AddPost_Load(object sender, EventArgs e)
        {
            string CommandText = "SELECT [Код_поставщика], [Наименование_поставщика] FROM [Поставщики] ";
            SqlConnection conn = new SqlConnection(text);
            SqlDataAdapter da = new SqlDataAdapter(CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Поиск]");
            bx_post.DataSource = ds.Tables["[Поиск]"].DefaultView;

            this.bx_post.DisplayMember = "Наименование_поставщика";
            this.bx_post.ValueMember = "Код_поставщика";
            this.bx_post.SelectedIndex = -1;

            string CommandText1 = "SELECT [Код_товара], [Наименование] FROM [Товар] ";
            SqlDataAdapter dq = new SqlDataAdapter(CommandText1, conn);
            DataSet dss = new DataSet();
            dq.Fill(dss, "[Поиск1]");
            bx_prod.DataSource = dss.Tables["[Поиск1]"].DefaultView;

            this.bx_prod.DisplayMember = "Наименование";
            this.bx_prod.ValueMember = "Код_товара";
            this.bx_prod.SelectedIndex = -1;
        }
    }
}
