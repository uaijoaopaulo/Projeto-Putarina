using Putarina.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Putarina.Repository
{
    public class RepositoryBase
    {
        private Database1Entities _DataModel;

        public Database1Entities DataModel
        {
            get{
                if(_DataModel==null)
                    _DataModel = new Database1Entities();
                return _DataModel;
            }
            set{
                _DataModel = value;
            }
        }
    }
}
