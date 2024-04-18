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
    public class UserMessageManager : IUserMessageService
    {
        IUserMessageDal _userMessageDal;

        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _userMessageDal = userMessageDal;
        }

        public List<UserMessage> GetUserMessageWithUserService()
        {
           return _userMessageDal.GetUserMessagesWithUsers();
        }

        public void TAdd(UserMessage t)
        {
            _userMessageDal.Insert(t);
        }

        public void TDelete(UserMessage t)
        {
           _userMessageDal.Delete(t);
        }

        public List<UserMessage> TGetByFilter()
        {
            throw new NotImplementedException();
        }

        public UserMessage TGetById(int id)
        {
            return _userMessageDal.GetByID(id);
        }

        public List<UserMessage> TGetList()
        {
            return _userMessageDal.GetList();
        }

        public void TUpdate(UserMessage t)
        {
           _userMessageDal.Update(t);
        }
    }
}
