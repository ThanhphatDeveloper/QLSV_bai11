using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class SinhVienDAO
   {
        QLSinhVienEntities qlsvEntities = new QLSinhVienEntities();
        public List<SinhVienDTO> LayDSSV()
        {
            
            return qlsvEntities.SinhViens.Select(u => new SinhVienDTO { ID = u.ID, MSSV = u.MSSV, Ho = u.Ho, Ten = u.Ten, MaLop = u.MaLop, NgaySinh = u.NgaySinh.Value, DiaChi = u.DiaChi, TrangThai = u.TrangThai.Value }).ToList();
        }


        public bool ThemSV(SinhVienDTO sv)
        {
            try
            {
                SinhVien svT = new SinhVien
                {
                    MSSV = sv.MSSV,
                    Ho = sv.Ho,
                    Ten = sv.Ten,
                    MaLop = sv.MaLop,
                    NgaySinh = sv.NgaySinh,
                    DiaChi = sv.DiaChi,
                    TrangThai = 1
                };
                qlsvEntities.SinhViens.Add(svT);
                qlsvEntities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public bool XoaSV(string mssv)
        {
            SinhVien svX = qlsvEntities.SinhViens.SingleOrDefault(u => u.MSSV == mssv);
            if (svX == null)
            {
                return false;
            }
            svX.TrangThai = 0;
            qlsvEntities.SaveChanges();
            return true;
        }
    }
}
