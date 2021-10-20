using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wareHouse
{
    public partial class CountProd : Form
    {
        public CountProd()
        {
            InitializeComponent();
        }

        private void CountProd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wareHouseDataSet2.CountProduct". При необходимости она может быть перемещена или удалена.
            this.CountProductTableAdapter.Fill(this.wareHouseDataSet2.CountProduct);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wareHouseDataSet1.CountProd". При необходимости она может быть перемещена или удалена.
            

            this.reportViewer1.RefreshReport();
        }
    }
}
