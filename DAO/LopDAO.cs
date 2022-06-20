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
            //return qlsvEntities.Lops.Select(u => new LopDTO { MaLop = u.MaLop, TenLop = u.TenLop}).ToList();

            return qlsvEntities.Lops.Select(u => new LopDTO { MaLop = u.MaLop, TenLop = u.TenLop}).ToList();
        }


    }
}
