using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class TheLoaiBus
    {
        Entities db;

        public TheLoaiBus()
        {
            db = Entities.CreateEntities();
        }

        public List<TheLoai> GetAll()
        {
            return db.TheLoais.ToList();
        }

        public List<TheLoaiDTO> GetAllDTO()
        {
            // LINQ query
            return (from tl in db.TheLoais
                    select new TheLoaiDTO() { MaTheLoai = tl.MaTheLoai, TenTheLoai = tl.TenTheLoai }).ToList();
        }
    }
}
