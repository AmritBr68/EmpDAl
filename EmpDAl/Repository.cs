using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDAl
{
    public class Repository : IRepository
    {
        static EmpContext _context;
        public Repository()
        {
            _context = new EmpContext();
        }
        public bool CancelEmployee(int id)
        {
            if(id!= null) 
            {
                var x = _context.Employees.Find(id);
                _context.Employees.Remove(x);
                _context.SaveChanges();
                return true;
            }
            else { return false; }

        }

        public bool RegisterEmployee(Employee eObj)
        {
            if (eObj != null) 
            {
                _context.Employees.Add(eObj);
                _context.SaveChanges();
                return true;
            }
            else { return false; }
            
        }

        public bool UpdateEmail(int id, string email)
        {
            if (id != null)
            {
                var p=_context.Employees.Find(id);
                p.Email= email;
                _context.SaveChanges();
                return true;
            }
            else { return false; }
        }
    }
}
