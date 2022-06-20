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

            dgvQLSV.AutoGenerateColumns = false;

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
            
        }
    }
}
