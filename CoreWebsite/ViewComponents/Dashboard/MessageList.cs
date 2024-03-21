﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebsite.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        UserMessageManager userMessageManager = new UserMessageManager(new EfUserMessageDal());
        public IViewComponentResult Invoke()
        {
            var values = userMessageManager.GetUserMessageWithUserService();
            return View(values);
        }
    }
}
