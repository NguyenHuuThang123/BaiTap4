using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo8
{
    public partial class Form2 : Form
    {


        public string MSNV { get; set; }
        public string TenNV { get; set; }
        public string LuongCB { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            MSNV = txtID.Text;
            TenNV = txtName.Text;
            LuongCB = txtLuong.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtID.Text = MSNV;
            txtName.Text = TenNV;
            txtLuong.Text = LuongCB;
        }
    }
}
