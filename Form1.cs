using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Demo8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem(form2.MSNV);
                item.SubItems.Add(form2.TenNV);
                item.SubItems.Add(form2.LuongCB);
                lsvNhanVien.Items.Add(item);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục đã chọn không?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    lsvNhanVien.Items.Remove(lsvNhanVien.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvNhanVien.SelectedItems[0];

                Form2 form2 = new Form2()
                {
                    MSNV = selectedItem.SubItems[0].Text,
                    TenNV = selectedItem.SubItems[1].Text,
                    LuongCB = selectedItem.SubItems[2].Text
                };
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    selectedItem.SubItems[0].Text = form2.MSNV;
                    selectedItem.SubItems[1].Text = form2.TenNV;
                    selectedItem.SubItems[2].Text = form2.LuongCB;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

