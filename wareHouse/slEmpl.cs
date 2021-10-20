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
    public partial class slEmpl : Form
    {
        public slEmpl()
        {
            InitializeComponent();
        }

        private void slEmpl_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wareHouseDataSet.slEmpl". При необходимости она может быть перемещена или удалена.
            this.slEmplTableAdapter.Fill(this.wareHouseDataSet.slEmpl);

            this.reportViewer1.RefreshReport();
        }
    }
}
