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
    public class EfWriterDal:GenericRepository<Writer>,IWriterDal
    {

        Context c = new Context();
        DbSet<Writer> _object;
        public EfWriterDal()
        {
            _object = c.Set<Writer>();
        }

        public Writer WriterGet(Writer p)
        {

            return _object.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);

        }
    }
}
