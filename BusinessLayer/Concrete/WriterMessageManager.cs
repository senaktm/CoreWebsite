using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BusinessLayer.Concrete
{
    public class WriterMessageManager : IGenericService<WriterMessage>,IWriterMessageService
    {
        IWriterMessageDal writerMessageDal;

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            this.writerMessageDal = writerMessageDal;
        }

        public List<WriterMessage> TGetByFilter()
        {
            //return writerMessageDal.TGetByFilter(x => x.Receiver == p);
            throw new NotImplementedException();
        }

        public void TAdd(WriterMessage t)
        {
            writerMessageDal.Insert(t);
        }

        public void TDelete(WriterMessage t)
        {
            writerMessageDal.Delete(t);
        }

        public WriterMessage TGetById(int id)
        {
            return writerMessageDal.GetByID(id);
        }

        public List<WriterMessage> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public List<WriterMessage> GetListSenderMessage(string p)
        {
            return writerMessageDal.TGetByFilter(x=>x.Sender ==p);
        }

        public List<WriterMessage> GetListReceiverMessage(string p)
        {
            return writerMessageDal.TGetByFilter(x=>x.Receiver ==p);
        }
    }
}
