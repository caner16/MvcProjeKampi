using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;
        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public Writer WriterGet1(Writer writer)
        {
            return _writerDal.WriterGet(writer);
        }

        public Writer GetByID(int id)
        {
            return _writerDal.Get(x=>x.WriterID == id); 
        }

        public List<Writer> Getlist()
        {
            return _writerDal.List();
        }

        public void Writeradd(Writer writer)
        {
             _writerDal.Insert(writer);
        }

        public void WriterDelete(Writer writer)
        {
            _writerDal.Delete(writer);
        }

        public void WriterUpdate(Writer writer)
        {
            _writerDal.Update(writer);
        }
    }
}
