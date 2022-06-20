using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LopBUS
    {
        private LopDAO lopDAO = new LopDAO();
        public List<LopDTO> LayDSLop()
        {
            return lopDAO.LayDSLop();
        }
        //public bool ThemLop(LopDTO themLop)
        //{
        //    return lopDAO.ThemLop(themLop);
        //}
        //public bool XoaLop(string malop)
        //{
        //    return lopDAO.XoaLop(malop);
        //}
        //public bool SuaLop(LopDTO suaLop)
        //{
        //    return lopDAO.SuaLop(suaLop);
        //}
    }
}
