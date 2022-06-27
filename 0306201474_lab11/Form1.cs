using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;
using DTO;
namespace _0306201474_lab11
{
    public partial class Form1 : Form
    {
        SinhVienBUS sinhVienBUS = new SinhVienBUS();
        LopBUS lopBUS = new LopBUS();
        public Form1()
        {
            InitializeComponent();

            //dgvQLSV.AutoGenerateColumns = false;

            cboLop.DataSource = lopBUS.LayDSLop();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";


            colLop.DataSource = lopBUS.LayDSLop();
            colLop.DisplayMember = "TenLop";
            colLop.ValueMember = "MaLop";

            dgvQLSV.DataSource = sinhVienBUS.LayDSSV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtHo.Text)|| string.IsNullOrEmpty(txtMssv.Text)|| string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(rtbDiachi.Text))
            {
                MessageBox.Show("Chưa có dữ liệu");
            }
            else 
            {
                SinhVienDTO sinhvien = new SinhVienDTO()
                {
                    MSSV = txtMssv.Text,
                    Ho = txtHo.Text,
                    Ten= txtTen.Text,
                    NgaySinh = dtpNgay.Value,
                    MaLop = cboLop.SelectedValue.ToString(),
                    DiaChi = rtbDiachi.Text
                };
                MessageBox.Show(sinhVienBUS.ThemSV(sinhvien) ? "Thêm thành công" : "Thêm thất bại");
                dgvQLSV.DataSource = null;
                dgvQLSV.DataSource = sinhVienBUS.LayDSSV();
            }
        }

        private void btnChinhsua_Click(object sender, EventArgs e)
        {
           if(dgvQLSV.SelectedRows.Count != 0)
            {
                SinhVienDTO sinhvien = new SinhVienDTO()
                {
                    MSSV = txtMssv.Text,
                    Ho = txtHo.Text,
                    Ten = txtTen.Text,
                    NgaySinh = dtpNgay.Value,
                    MaLop = cboLop.SelectedValue.ToString(),
                    DiaChi = rtbDiachi.Text
                };

                MessageBox.Show(sinhVienBUS.SuaSV(sinhvien) ? "Sửa thành công" : "Thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvQLSV.SelectedRows.Count != 0)
            {
                MessageBox.Show(sinhVienBUS.XoaSV(txtMssv.Text) ? " thành công" : "Xoá thất bại");

                dgvQLSV.DataSource = null;
                dgvQLSV.DataSource = sinhVienBUS.LayDSSV();
            }
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMssv.Text = string.Empty;
            txtHo.Text = string.Empty;
            txtTen.Text = string.Empty;
        }
    }
}
