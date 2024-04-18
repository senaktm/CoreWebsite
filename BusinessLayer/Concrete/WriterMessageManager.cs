﻿using BusinessLayer.Abstract;
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
    public class WriterMessageManager : IGenericService<WriterMessage>
    {
        IWriterMessageDal writerMessageDal;

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            this.writerMessageDal = writerMessageDal;
        }

        public List<WriterMessage> TGetByFilter(string p)
        {
            return writerMessageDal.TGetByFilter(x=>x.Receiver ==p);
        }

        public void TAdd(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public WriterMessage TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<WriterMessage> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterMessage t)
        {
            throw new NotImplementedException();
        }

    }
}
