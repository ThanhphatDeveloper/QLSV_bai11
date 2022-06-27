using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SinhVienBUS
    {
        private SinhVienDAO sinhVien= new SinhVienDAO();

        public List<SinhVienDTO> LayDSSV()
        {
            return sinhVien.LayDSSV();
        }
        public bool ThemSV(SinhVienDTO sinhVienT)
        {
            return sinhVien.ThemSV(sinhVienT);
        }
        public bool XoaSV(string mssv)
        {
            return sinhVien.XoaSV(mssv);
        }
        public bool SuaSV(SinhVienDTO sinhVienS)
        {
            return sinhVien.SuaSV(sinhVienS);
        }
    }
}
