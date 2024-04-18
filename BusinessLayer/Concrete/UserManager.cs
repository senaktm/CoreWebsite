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
    public class UserManager : IGenericService<User>
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void TAdd(User t)
        {
            _userDal.Insert(t);
        }

        public void TDelete(User t)
        {
            _userDal.Delete(t);
        }

        public List<User> TGetByFilter()
        {
            throw new NotImplementedException();
        }

        public User TGetById(int id)
        {
            return _userDal.GetByID(id);
        }

        public List<User> TGetList()
        {
           return _userDal.GetList();
        }

        public void TUpdate(User t)
        {
            _userDal.Update(t);
        }
    }
}
