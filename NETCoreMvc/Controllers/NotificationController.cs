using BusinessLayer.Concretes;
using DataAccessLayer.Concretes.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NETCoreMvc.Controllers
{
    public class NotificationController : Controller
    {
        NotificationManager notificationManager=new NotificationManager( new NotificationRepository() );
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous] 
        public IActionResult AllNotification()
        {
            var values = notificationManager.GetAll();
            return View( values );
        }
    }
}
