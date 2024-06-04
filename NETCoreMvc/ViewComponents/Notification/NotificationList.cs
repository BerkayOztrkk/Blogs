using BusinessLayer.Concretes;
using DataAccessLayer.Concretes.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace NETCoreMvc.ViewComponents.Notification
{
    public class NotificationList:ViewComponent
    {
        NotificationManager _notificationManager = new NotificationManager(new NotificationRepository());
        public IViewComponentResult Invoke()
        {
            var values=_notificationManager.GetAll();
            return View(values);
        }
    }
}
