using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void menuCategory_Click(object sender, EventArgs e)
        {
            CategoryUI category = new CategoryUI();
            category.MdiParent = this;
            category.Show();
        }

        private void menuProduct_Click(object sender, EventArgs e)
        {
            ProductUI product = new ProductUI();
            product.MdiParent = this;
            product.Show();
        }
    }
}
