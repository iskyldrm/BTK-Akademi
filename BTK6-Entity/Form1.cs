using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTK6_Entity
{
    public partial class Form1 : Form
    {
        ShipperDal ShipperDal = new ShipperDal();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadShipper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShipperDal.Add(new Shipper
            {
                CompanyName = textBox2.Text,
                Phone = textBox3.Text,    
                
            });
            LoadShipper();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            ShipperDal.Update(new Shipper
            {
                ShipperId = Convert.ToInt32(textBox6.Text),
                CompanyName = textBox5.Text,
                Phone = textBox4.Text,
            });

            LoadShipper();
            
        }
        public void LoadShipper()
        {
            dataGridView1.DataSource = ShipperDal.GetAll();  
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

        }
    }
}
