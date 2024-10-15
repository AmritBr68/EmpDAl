using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDAl
{
    public interface IRepository
    {
        public bool RegisterEmployee(Employee eObj);
        public bool CancelEmployee(int id);
        public bool UpdateEmail(int id, string email);
    }
}
