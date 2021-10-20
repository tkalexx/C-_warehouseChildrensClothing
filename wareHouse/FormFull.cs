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
using System.Diagnostics;

namespace wareHouse
{
    public partial class FormFull : Form
    {
        string text = "Server=(local);Initial Catalog=wareHouse;Trusted_connection=Yes";

        private void Connect()
        {
            SqlConnection conn = new SqlConnection(text);
            try
            {
                //Открыть подключение
                conn.Open();
            }
            catch (Exception ex)
            {
                //Сообщение об ошибке
                MessageBox.Show(ex.Message);
            }

            finally
            {
                //Закрываем подключение
                conn.Close();
            }

        }

        public FormFull()
        {
            InitializeComponent();
        }

        private void FillClients()
        {
            SqlConnection conn = new SqlConnection(text);
            string SqlText = "SELECT * FROM [Клиенты]";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Клиенты]");
            grid_clients.DataSource = ds.Tables["[Клиенты]"].DefaultView;
            grid_clients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_clients.Columns[0].Visible = false;
        }

        private void FillEmployees()
        {
            SqlConnection conn = new SqlConnection(text);
            string SqlText = "SELECT * FROM [Сотрудники]";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Сотрудники]");
            grid_employees.DataSource = ds.Tables["[Сотрудники]"].DefaultView;
            grid_employees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_employees.Columns[0].Visible = false;
        }

        private void FillProduct()
        {
            SqlConnection conn = new SqlConnection(text);
            string SqlText = "SELECT * FROM [Товар]";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Товар]");
            grid_product.DataSource = ds.Tables["[Товар]"].DefaultView;
            grid_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_product.Columns[0].Visible = false;
        }

        private void FillPostavki()
        {
            SqlConnection conn = new SqlConnection(text);
            string SqlText = "SELECT * FROM [Поставки]";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Поставки]");
            grid_postav.DataSource = ds.Tables["[Поставки]"].DefaultView;
            grid_postav.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_postav.Columns[0].Visible = false;
        }

        private void FillPt()
        {
            SqlConnection conn = new SqlConnection(text);
            string SqlText = "SELECT * FROM [Поставщики]";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Поставщики]");
            grid_pt.DataSource = ds.Tables["[Поставщики]"].DefaultView;
            grid_pt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_pt.Columns[0].Visible = false;
        }

        private void FillSell()
        {
            SqlConnection conn = new SqlConnection(text);
            string SqlText = "SELECT Код_заказа, Заказы.Код_товара, Товар.Наименование, Заказы.Код_клиента, Клиенты.ФИО, Заказы.Код_сотрудника, Сотрудники.ФИО, Дата_заказа, Дата_доставки, Количество, Итоговая_стоимость FROM Заказы inner join Клиенты on Заказы.Код_клиента = Клиенты.Код_клиента inner join Сотрудники On Заказы.Код_сотрудника = Сотрудники.Код_сотрудника inner join Товар On Заказы.Код_товара = Товар.Код_товара ";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Заказы]");
            grid_sell.DataSource = ds.Tables["[Заказы]"].DefaultView;
            grid_sell.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_sell.Columns[0].Visible = false;
            this.grid_sell.Columns[1].Visible = false;
            this.grid_sell.Columns[3].Visible = false;
            this.grid_sell.Columns[5].Visible = false;
        }

        public void MyExecuteNonQuery(string SqlText)
        {

            SqlConnection cn = new SqlConnection(text);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = SqlText;
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void FormFull_Load(object sender, EventArgs e)
        {

            this.Connect();
            FillClients();
            FillEmployees();
            FillProduct();
            FillSell();
            FillPt();
            FillPostavki();

            }

        private void btn_addEmployees_Click(object sender, EventArgs e)
        {
            string SqlText = " ";
            AddEmpl f = new AddEmpl();

            if (f.ShowDialog() == DialogResult.OK)
            {
                SqlText = "INSERT INTO [Сотрудники] ([ФИО], [Должность], [Домашний_адрес], [Телефон], [Зарплата]) VALUES (";
                SqlText = SqlText + "\'" + f.fio.Text + "\', ";
                SqlText = SqlText + "\'" + f.post.Text + "\', ";
                SqlText = SqlText + "\'" + f.address.Text + "\', ";
                SqlText = SqlText + "\'" + f.phone.Text + "\', ";
                SqlText = SqlText + "\'" + f.salary.Text + "\')";
                MyExecuteNonQuery(SqlText);

               

                string id_employees = "(SELECT MAX(Код_сотрудника) FROM Сотрудники)";
                MyExecuteNonQuery(id_employees);

                SqlText = "INSERT INTO [Авторизация] ([Код_сотрудника], [Логин], [Пароль]) VALUES (";
                SqlText = SqlText + id_employees + ", ";
                SqlText = SqlText + "\'" + f.log.Text + "\', ";
                SqlText = SqlText + "\'" + f.pass.Text + "\')";
                MyExecuteNonQuery(SqlText);


                if (f.box_dost.SelectedIndex == 0)
                {
                    SqlText = "INSERT INTO [РазрешениеДоступа] ([Код_сотрудника], [Код_доступа]) VALUES (";
                    SqlText = SqlText + id_employees + ", ";
                    SqlText = SqlText + "\'" + "1" + "\')";
                    MyExecuteNonQuery(SqlText);
                }

                if (f.box_dost.SelectedIndex == 1)
                {
                    SqlText = "INSERT INTO [РазрешениеДоступа] ([Код_сотрудника], [Код_доступа]) VALUES (";
                    SqlText = SqlText + id_employees + ", ";
                    SqlText = SqlText + "\'" + "2" + "\')";
                    MyExecuteNonQuery(SqlText);
                }

               
            }
            FillEmployees();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index, n;
            string id_employees;
            string fio, post;

            n = grid_employees.Rows.Count;
            if (n == 1) return;

            DellEmpl f = new DellEmpl();

            index = grid_employees.CurrentRow.Index;
            id_employees = Convert.ToString(grid_employees[0, index].Value);

            string SqlText1 = "DELETE FROM [Авторизация] WHERE [Авторизация].Код_Сотрудника = ";

            string SqlText2 = "DELETE FROM [РазрешениеДоступа] WHERE [РазрешениеДоступа].Код_Сотрудника = ";

            string SqlText = "DELETE FROM [Сотрудники] WHERE [Сотрудники].Код_Сотрудника = ";

           

            SqlText1 = SqlText1 + id_employees;
            SqlText2 = SqlText2 + id_employees;
            SqlText = SqlText + id_employees;

            fio = Convert.ToString(grid_employees[1, index].Value);
            post = Convert.ToString(grid_employees[2, index].Value);
            f.fioEmpl.Text = id_employees + " - " + fio + " - " + post;

            if (f.ShowDialog() == DialogResult.OK)
            {
                MyExecuteNonQuery(SqlText2);
                MyExecuteNonQuery(SqlText1);
                
                MyExecuteNonQuery(SqlText);
                FillEmployees();
            }
        }

        private void editEmpl_Click(object sender, EventArgs e)
        {
            int index, n;
            string SqlText = "UPDATE [Сотрудники] SET ";
            string id_empl, fio, post, address, phone, salary;

            n = grid_employees.Rows.Count;
            if (n == 1) return;

            editEmpl f = new editEmpl();


            index = grid_employees.CurrentRow.Index;

            id_empl = grid_employees[0, index].Value.ToString();
            fio = grid_employees[1, index].Value.ToString();
            post = grid_employees[2, index].Value.ToString();
            address = grid_employees[3, index].Value.ToString();
            phone = grid_employees[4, index].Value.ToString();
            salary = grid_employees[5, index].Value.ToString();

            f.fio.Text = fio;
            f.post.Text = post;
            f.address.Text = address;
            f.phone.Text = phone;
            f.salary.Text = salary;

            if (f.ShowDialog() == DialogResult.OK)
            {
                fio = f.fio.Text;
                post = f.post.Text;
                address = f.address.Text;
                phone = f.phone.Text;
                salary = f.salary.Text;
                SqlText += "ФИО = \'" + fio + "\', Должность = '" + post + "\', Домашний_адрес = '" + address + "\', Телефон = '" + phone + "\', Зарплата = '" + salary + "\'";
                SqlText += "WHERE [Сотрудники].Код_сотрудника = " + id_empl;
                MyExecuteNonQuery(SqlText);
                FillEmployees();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        DataSet ds = new DataSet();

        private void btn_enter_Click(object sender, EventArgs e)
        {
            string CommandText = "";
            if (param.Text == " ")
            {
                return;
            };
            if (box_table.SelectedIndex == 0)
            {
                CommandText = "SELECT [ФИО],[Паспорт],[Домашний_адрес],[Телефон] FROM [Клиенты] WHERE ";
            }

            if (box_table.SelectedIndex == 1)
            {
                CommandText = "SELECT [ФИО],[Должность],[Домашний_адрес],[Телефон],[Зарплата] FROM [Сотрудники] WHERE ";
            }
            if (box_table.SelectedIndex == 2)
            {
                CommandText = "SELECT [Наименование],[Цена],[Наличие] FROM [Товар] WHERE ";
            }
            
            if (box_param.SelectedIndex == 0)
            {
                CommandText += " " + box_str.Text + " " + box_param.Text + " " + "'%" + param.Text + "%'";
            }
            if (box_param.SelectedIndex == 1 || box_param.SelectedIndex == 2 || box_param.SelectedIndex == 3)
            {
                CommandText += " " + box_str.Text + " " + box_param.Text + " '" + param.Text + " '";
            }

            SqlConnection conn = new SqlConnection(text);
            SqlDataAdapter da = new SqlDataAdapter(CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Поиск]");
            grid_poisk.DataSource = ds.Tables["[Поиск]"].DefaultView;
            grid_poisk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void box_table_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void box_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (box_table.SelectedIndex == 0)
            {
                box_str.Items.Clear();
                for (int i = 0; i < grid_clients.ColumnCount; i++)
                {
                    box_str.Items.Add(grid_clients.Columns[i].HeaderText);
                }
            }
            if (box_table.SelectedIndex == 1)
            {
                box_str.Items.Clear();
                for (int i = 0; i < grid_employees.ColumnCount; i++)
                {
                    box_str.Items.Add(grid_employees.Columns[i].HeaderText);
                }
            }
            if (box_table.SelectedIndex == 2)
            {
                box_str.Items.Clear();
                for (int i = 0; i < grid_product.ColumnCount; i++)
                {
                    box_str.Items.Add(grid_product.Columns[i].HeaderText);
                }
            }

            if (box_table.SelectedIndex == 3)
            {
                box_str.Items.Clear();
                for (int i = 0; i < grid_sell.ColumnCount; i++)
                {
                    box_str.Items.Add(grid_sell.Columns[i].HeaderText);
                }
            }
        }

        private void btn_summEmpl_Click(object sender, EventArgs e)
        {
            slEmpl f = new slEmpl();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CountProd f = new CountProd();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(text);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(Заказы.Итоговая_стоимость) AS Summ FROM Заказы ";
            object result = cmd.ExecuteScalar();
            int a = Convert.ToInt32(result);
            conn.Close();
            tx_box_s.Text = a.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string CommandText = "";
            CommandText = "SELECT Товар.Наименование, Дата_заказа, Дата_доставки, Итоговая_стоимость, Сотрудники.ФИО from Товар, Сотрудники, Заказы WHERE Заказы.Дата_заказа Between";
            CommandText += " '" + dateTimePicker1.Value.ToShortDateString() + "' ";
            CommandText += " and ";
            CommandText += " '" + dateTimePicker2.Value.ToShortDateString() + "' ";
            CommandText += " and Товар.Код_товара = Заказы.Код_товара and Сотрудники.Код_сотрудника = Заказы.Код_сотрудника";
            SqlConnection conn = new SqlConnection(text);
            SqlDataAdapter da = new SqlDataAdapter(CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Запр]");
            dataGridView1.DataSource = ds.Tables["[Запр]"].DefaultView;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           // ItogPoZp f = new ItogPoZp();
          //  f.Show();
        }

        private void btn_addT_Click(object sender, EventArgs e)
        {
            string SqlText = " ";
            AddProd f = new AddProd();

            if (f.ShowDialog() == DialogResult.OK)
            {
                SqlText = "INSERT INTO [Товар] ([Наименование], [Цена], [Наличие]) VALUES (";
                SqlText = SqlText + "\'" + f.name_t.Text + "\', ";
                SqlText = SqlText + "\'" + f.sal_t.Text + "\', ";
                SqlText = SqlText + "\'" + f.cou_t.Text + "\')";
                MyExecuteNonQuery(SqlText);

            }
            FillProduct();
        }

        private void btn_delT_Click(object sender, EventArgs e)
        {
            int index, n;
            string id_prod;
            string fio;
            string SqlText = "DELETE FROM [Товар] WHERE [Товар].Код_товара = ";

            n = grid_product.Rows.Count;
            if (n == 1) return;

            delProd f = new delProd();

            index = grid_product.CurrentRow.Index;
            id_prod = Convert.ToString(grid_product[0, index].Value);

            SqlText = SqlText + id_prod;

            fio = Convert.ToString(grid_product[1, index].Value);
            
            f.name_t.Text = id_prod + " - " + fio;

            if (f.ShowDialog() == DialogResult.OK)
            {
                MyExecuteNonQuery(SqlText);
                FillProduct();
            }
        }

        private void btn_editT_Click(object sender, EventArgs e)
        {
            int index, n;
            string SqlText = "UPDATE [Товар] SET ";
            string id_prod, name_t, sal_t, cou_t;

            n = grid_product.Rows.Count;
            if (n == 1) return;

            editProd f = new editProd();


            index = grid_product.CurrentRow.Index;

            id_prod = grid_product[0, index].Value.ToString();
            name_t = grid_product[1, index].Value.ToString();
            sal_t = grid_product[2, index].Value.ToString();
            cou_t = grid_product[3, index].Value.ToString();

            f.name_t.Text = name_t;
            f.sal_t.Text = sal_t;
            f.cou_t.Text = cou_t;

            if (f.ShowDialog() == DialogResult.OK)
            {
                name_t = f.name_t.Text;
                sal_t = f.sal_t.Text;
                cou_t = f.cou_t.Text;
               
                SqlText += "Наименование = \'" + name_t + "\', Цена = '" + sal_t + "\',  Наличие = '" + cou_t + "\'";
                SqlText += "WHERE [Товар].Код_товара = " + id_prod;
                MyExecuteNonQuery(SqlText);
                FillProduct();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string SqlText = " ";
            AddPost f = new AddPost();

            if (f.ShowDialog() == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(text);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Наличие FROM Товар WHERE Код_товара =\' " + f.bx_prod.SelectedValue.ToString() + "\'";
                object result = cmd.ExecuteScalar();
                int a = Convert.ToInt32(result);
                conn.Close();
                
                int countProd = Convert.ToInt32(f.tx_couT.Text) + a; 
                SqlText = "INSERT INTO [Поставки] ([Код_поставщика], [Код_товара], [Количество]) VALUES (";
                SqlText = SqlText + "\'" + f.bx_post.SelectedValue.ToString() + "\', ";
                SqlText = SqlText + "\'" + f.bx_prod.SelectedValue.ToString() + "\', ";
                SqlText = SqlText + "\'" + f.tx_couT.Text + "\')";
                MyExecuteNonQuery(SqlText);
                MessageBox.Show("Поставка добавлена!");

                string SqlTextq = "UPDATE [Товар] SET ";
                SqlTextq += "Наличие = \'" + countProd + "\'";
                SqlTextq += "WHERE [Товар].Код_товара = " + f.bx_prod.SelectedValue.ToString();
                MyExecuteNonQuery(SqlTextq);
                FillProduct();
            }
            FillPostavki();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int index, n;
            string id_postavk;
            string fio;
            string SqlText = "DELETE FROM [Поставки] WHERE [Поставки].Код_поставки = ";

            n = grid_postav.Rows.Count;
            if (n == 1) return;

            delPostavk f = new delPostavk();

            index = grid_postav.CurrentRow.Index;
            id_postavk = Convert.ToString(grid_postav[0, index].Value);

            SqlText = SqlText + id_postavk;

            fio = Convert.ToString(grid_postav[1, index].Value);

            f.lbl_postavka.Text = id_postavk + " - " + fio;

            if (f.ShowDialog() == DialogResult.OK)
            {
                MyExecuteNonQuery(SqlText);
                FillPostavki();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int index, n;
            string SqlText = "UPDATE [Поставки] SET ";
            string id_post, id_postav, id_prod, cou_t;

            n = grid_postav.Rows.Count;
            if (n == 1) return;

            editPostavki f = new editPostavki();


            index = grid_postav.CurrentRow.Index;

            id_post = grid_postav[0, index].Value.ToString();
            id_postav = grid_postav[1, index].Value.ToString();
            id_prod = grid_postav[2, index].Value.ToString();
            cou_t = grid_postav[3, index].Value.ToString();

            f.textBox1.Text = id_postav;
            f.textBox2.Text = id_prod;
            f.textBox3.Text = cou_t;

            if (f.ShowDialog() == DialogResult.OK)
            {
                id_postav = f.textBox1.Text;
                id_prod = f.textBox2.Text;
                cou_t = f.textBox3.Text;

                SqlText += "Код_поставщика = \'" + id_postav + "\', Код_товара = '" + id_prod + "\',  Количество = '" + cou_t + "\'";
                SqlText += "WHERE [Поставки].Код_поставки = " + id_post;
                MyExecuteNonQuery(SqlText);
                FillPostavki();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string SqlText = " ";
            AddPt f = new AddPt();

            if (f.ShowDialog() == DialogResult.OK)
            {
                SqlText = "INSERT INTO [Поставщики] ([Наименование_поставщика], [Телефон], [Адрес]) VALUES (";
                SqlText = SqlText + "\'" + f.name_t.Text + "\', ";
                SqlText = SqlText + "\'" + f.sal_t.Text + "\', ";
                SqlText = SqlText + "\'" + f.cou_t.Text + "\')";
                MyExecuteNonQuery(SqlText);
                MessageBox.Show("Поставщик добавлен!");

            }
            FillPt();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int index, n;
            string id_postavk;
            string fio;
            string SqlText = "DELETE FROM [Поставщики] WHERE [Поставщики].Код_поставщика = ";
            string SqlText2 = "DELETE FROM [Поставки] WHERE [Поставки].Код_поставщика = ";

            n = grid_pt.Rows.Count;
            if (n == 1) return;

            DelPt f = new DelPt();

            index = grid_pt.CurrentRow.Index;
            id_postavk = Convert.ToString(grid_pt[0, index].Value);

            SqlText = SqlText + id_postavk;
            SqlText2 = SqlText2 + id_postavk;

            fio = Convert.ToString(grid_pt[1, index].Value);

            f.lbl_pt.Text = id_postavk + " - " + fio;

            if (f.ShowDialog() == DialogResult.OK)
            {   
                MyExecuteNonQuery(SqlText2);
                MyExecuteNonQuery(SqlText);
                
                FillPt();
                FillPostavki();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int index, n;
            string SqlText = "UPDATE [Поставщики] SET ";
            string id_post, name_pt, phn_pt, adr_pt;

            n = grid_pt.Rows.Count;
            if (n == 1) return;

            editPt f = new editPt();


            index = grid_pt.CurrentRow.Index;

            id_post = grid_pt[0, index].Value.ToString();
            name_pt = grid_pt[1, index].Value.ToString();
            phn_pt = grid_pt[2, index].Value.ToString();
            adr_pt = grid_pt[3, index].Value.ToString();

            f.textBox1.Text = name_pt;
            f.textBox2.Text = phn_pt;
            f.textBox3.Text = adr_pt;

            if (f.ShowDialog() == DialogResult.OK)
            {
                name_pt = f.textBox1.Text;
                phn_pt = f.textBox2.Text;
                adr_pt = f.textBox3.Text;

                SqlText += "Наименование_поставщика = \'" + name_pt + "\', Телефон = '" + phn_pt + "\',  Адрес = '" + adr_pt + "\'";
                SqlText += "WHERE [Поставщики].Код_поставщика = " + id_post;
                MyExecuteNonQuery(SqlText);
                FillPt();
            }
        }
    }
}
