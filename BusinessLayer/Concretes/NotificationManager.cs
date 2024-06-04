using BusinessLayer.Abstractions;
using DataAccessLayer.Abstractions.Repositories;
using DataAccessLayer.Concretes.Repositories;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concretes
{
    public class NotificationManager : INotificationService
    {
        INotificationRepository notificationRepository;

        public NotificationManager(INotificationRepository notificationRepository)
        {
            this.notificationRepository=notificationRepository;
        }

        public List<Notification> GetAll()
        {
          return notificationRepository.GetAll();
        }

        public Notification GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Notification t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Notification t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Notification t)
        {
            throw new NotImplementedException();
        }
    }
}
