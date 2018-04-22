using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.LinQ;

namespace QLThuVien
{
    class ClassConnection
    {
        DataClassesConnectionDataContext db;

        public ClassConnection()
        {
            db = new DataClassesConnectionDataContext();
        }

        public DataClassesConnectionDataContext database()
        {
            return db;
        }
    }
}
