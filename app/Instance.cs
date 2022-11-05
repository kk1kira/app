using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class Instance
    {
        private static PracticeEntities _db = null;
        public static PracticeEntities db
        {
            get
            {
                if (_db == null)
                    _db = new PracticeEntities();
                return _db;
            }
        }
    }
}
