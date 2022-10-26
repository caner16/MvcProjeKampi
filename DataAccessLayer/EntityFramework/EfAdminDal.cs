using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfAdminDal: GenericRepository<Admin>, IAdmindal
    {
       
        Context c = new Context();
        DbSet<Admin> _object;
        public EfAdminDal()
        {
            _object = c.Set<Admin>();
        }
        
        public Admin AdminGet(Admin p)
        {

           return _object.FirstOrDefault(x => x.AdminUserName == p.AdminUserName && x.AdminPassword == p.AdminPassword);

        }
        public Admin AdminRole(string p)
        {
            return _object.FirstOrDefault(x => x.AdminUserName == p);
        }
       

    }
}
