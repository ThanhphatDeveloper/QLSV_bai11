using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO
{
    public class LopDAO
    {
        QLSinhVienEntities qlsvEntities = new QLSinhVienEntities();
        public List<LopDTO> LayDSLop()
        {
            return qlsvEntities.Lops.Where(u => u.TrangThai == 1).Select(u => new LopDTO { MaLop = u.MaLop, TenLop = u.TenLop, TrangThai = u.TrangThai.Value }).Where(u => u.TrangThai == 1).ToList();
        }
        //        public bool ThemLop(LopDTO lop)
        //        {
        //            try
        //            {
        //                Lop lopT = new Lop
        //                {
        //                    MaLop = lop.MaLop,
        //                    TenLop = lop.TenLop,
        //                    //TrangThai = 1,
        //                };
        //                qlsvEntities.Lops.Add(lopT);
        //                qlsvEntities.SaveChanges();
        //                return true;
        //            }
        //            catch (Exception e)
        //            {
        //                return false;
        //            }
        //        }
        //        public bool XoaLop(string malop)
        //        {
        //            Lop xoaLop = qlsvEntities.Lops.SingleOrDefault(u => u.MaLop == malop);
        //            if (xoaLop == null)
        //            {
        //                return false;
        //            }
        //            //xoaLop.TrangThai = 0;
        //            qlsvEntities.SaveChanges();
        //            return true;
        //        }

        //        public bool SuaLop(LopDTO lop)
        //        {
        //            Lop suaLop = qlsvEntities.Lops.SingleOrDefault(u => u.MaLop == lop.MaLop);
        //            if (suaLop == null)
        //            {
        //                return false;
        //            }
        //            else
        //            {
        //                suaLop.MaLop = lop.MaLop;
        //                suaLop.TenLop = lop.TenLop;
        //                qlsvEntities.SaveChanges();
        //                return true;
        //            }
        //        }
        //    }
    }
}
