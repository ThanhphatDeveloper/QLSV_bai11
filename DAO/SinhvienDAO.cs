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
        //string connectstring = @"Data Source=DESKTOP-1IH4FH5\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True";
        QLSinhVienEntities qlsvEntities = new QLSinhVienEntities();
        public List<SinhVienDTO> LayDSSV()
        {
            //List<SinhVienDTO> sinhVienDTO = new List<SinhVienDTO>();
            //List<SinhVien> sinhVienEnts = new List<SinhVien>();
            //sinhVienEnts = qlsvEntities.SinhViens.ToList<SinhVien>();
            //sinhVienDTO = sinhVienEnts.Select(u => new SinhVienDTO { ID = u.ID, MSSV = u.MSSV }).ToList();
            return qlsvEntities.SinhViens.Select(u => new SinhVienDTO { ID = u.ID, MSSV = u.MSSV, Ho = u.Ho, Ten = u.Ten, MaLop = u.MaLop, NgaySinh = u.NgaySinh.Value, DiaChi = u.DiaChi, TrangThai = u.TrangThai.Value }).Where(u => u.TrangThai == 1).ToList();
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
            SinhVien sv = qlsvEntities.SinhViens.SingleOrDefault(u => u.MSSV == mssv);

            if (sv == null)
            {
                return false;
            }
            sv.TrangThai = 0;
            qlsvEntities.SaveChanges();
            return true;
        }
        public bool SuaSV(SinhVienDTO sv)
        {
            SinhVien svs = qlsvEntities.SinhViens.SingleOrDefault(u => u.MSSV == sv.MSSV);
            if (svs == null)
            {
                return false;
            }
            else
            {
                svs.Ho = sv.Ho;
                svs.Ten = sv.Ten;
                svs.MaLop = sv.MaLop;
                svs.NgaySinh = sv.NgaySinh;
                svs.DiaChi = sv.DiaChi;
                qlsvEntities.SaveChanges();
                return true;
            }

        }
    }
}
