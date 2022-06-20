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
        private SinhVienDAO sinhVienDAO = new SinhVienDAO();
        
        public List<SinhVienDTO> LayDSSV()
        {
            return sinhVienDAO.LayDSSV().Where(u => u.TrangThai == 1).ToList();
        }

        public bool ThemSV(SinhVienDTO sinhVienT)
        {
            return sinhVienDAO.ThemSV(sinhVienT);
        }

        public bool XoaSV(string mssv)
        {
            return sinhVienDAO.XoaSV(mssv);
        }

    }
}
