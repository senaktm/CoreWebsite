﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebsite.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Message")]
    public class MessageController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        [Route("")]
        [Route("ReceiverMessage")]
        public async Task<IActionResult> ReceiverMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = writerMessageManager.GetListReceiverMessage(p);
            return View(messageList);
        }
        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = writerMessageManager.GetListSenderMessage(p);
            return View(messageList);
        }

        [HttpGet]
       
        [Route("MessageDetails/{id}")]
        public IActionResult MessageDetails(int id)
        {
            var values = writerMessageManager.TGetById(id);
            return View(values);
        }
        [HttpGet]
        [Route("")]
        [Route("SendMessage")]
        public IActionResult SendMessage()
        {
            
            return View();
        }
        [HttpPost]
        [Route("")]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(WriterMessage p)
        {
            Context c = new Context();

            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();

            p.ReceiverName = usernamesurname;
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name+" "+values.Surname;
      
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Sender = mail;
            p.SenderName = name;
           
       
            writerMessageManager.TAdd(p);
            return RedirectToAction("SenderMessage");
        }
    }
}
