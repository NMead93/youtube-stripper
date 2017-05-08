using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YouStrip.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace YouStrip.Controllers
{
    [Route("api/[controller]")]
    public class YouStripController : Controller
    {
        public IActionResult GetMessages()
        {
            var allMessages = Message.GetMessages();
            return View(allMessages);
        }

        [HttpGet("[action]/{content}")]
        public IActionResult SendText(string content)
        {
            Message newMessage = new Message(content);
            newMessage.Send();
            return RedirectToAction("Index");
        }

        //[HttpGet("[action]")]
        //public IActionResult SendMessage()
        //{
        //    Message newMessage = new Message();
        //    newMessage.Send();
        //    return RedirectToAction("Index");
        //}
    }
}
