﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IGenericService<Contact>
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetList();
        }

        public void TAdd(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void TDelete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetByID(id);
        }

        public void TUpdate(Contact t)
        {
            _contactDal.Update(t);
        }

        public List<Contact> TGetByFilter(Expression<Func<Contact, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
