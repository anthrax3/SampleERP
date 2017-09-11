using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MI.ERP.BackEndServices.Common.Domain
{
    public class SystemUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Pwd { get; set; }
        public string UserRole { get; set; }
    }
}
