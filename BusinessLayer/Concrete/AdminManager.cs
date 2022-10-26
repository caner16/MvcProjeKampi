using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdmindal _admindal;
       

        public AdminManager(IAdmindal admindal)
        {
            _admindal = admindal;
        }

        public void AdminAdd(Admin admin)
        {
            _admindal.Insert(admin);
        }

        public void AdminDelete(Admin admin)
        {
           _admindal.Delete(admin);
        }

        public Admin AdminGet1(Admin admin)
        {
           return _admindal.AdminGet(admin);
        }

        public Admin AdminRole1(string p)
        {
            return _admindal.AdminRole(p);
        }

        public void AdminUpdate(Admin admin)
        {
            _admindal.Update(admin);
        }

        public Admin GetByID(int id)
        {
            return _admindal.Get(x => x.AdminID == id);
        }

     

        public List<Admin> GetList()
        {
           return _admindal.List();
        }

        
    }
}
