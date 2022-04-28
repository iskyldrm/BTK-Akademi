using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTK_ReCapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            ReProducts();
            ReCategories();
            
        }

        public void ReProducts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dataGridView1.DataSource = context.Products.ToList();
            }
        }
        public void ReCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                comboBox1.DataSource = context.Categories.ToList();
                comboBox1.DisplayMember = "CategoryName";
                comboBox1.ValueMember = "CategoryID";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ReProductsByCategoryID(Convert.ToInt32(comboBox1.SelectedValue));

            }
            catch (Exception)
            {

                
            }
            
            
        }

        private void ReProductsByCategoryID(int categoryID)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dataGridView1.DataSource = context.Products.Where(x=>x.CategoryID == categoryID).ToList();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == null)
            {
                ReProducts();
            }
            else
            {
                ReProductsByText(textBox2.Text);
            }
            
        }

        private void ReProductsByText(string text)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dataGridView1.DataSource = context.Products.Where(x => x.ProductName.Contains(textBox2.Text)).ToList();
            }
        }
    }
}
