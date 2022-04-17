using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

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
    }
}
