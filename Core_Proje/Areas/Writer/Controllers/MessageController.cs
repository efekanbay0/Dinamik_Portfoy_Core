using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class MessageController : Controller
    {
        WriterMessageManager writermessageManager = new WriterMessageManager(new EfWriterMessageDal());

        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> ReceiverMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = writermessageManager.GetListReceiverMessage(p); 
            return View(messageList);
        }

        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = writermessageManager.GetListSenderMessage(p);
            return View(messageList);
        }
        public IActionResult MessageDetails(int id)
        {
            WriterMessage writerMessage = writermessageManager.TGetByID(id);
            return View(writerMessage);
        }
        public IActionResult ReceiverMessageDetails(int id)
        {
            WriterMessage writerMessage = writermessageManager.TGetByID(id);
            return View(writerMessage);
        }

    }
}
