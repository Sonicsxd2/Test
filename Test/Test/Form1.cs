using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Дааа Кирюша ГАНГСТЕР!", "Патриарх.ру");
            }
            else MessageBox.Show("Ты че не веришь в ГАНГСТЕРОВ? ЗА ТОБОЙ УЖЕ ВЫЕХАЛИ!11", "Патриарх.ру");
        }

        
    }
}
