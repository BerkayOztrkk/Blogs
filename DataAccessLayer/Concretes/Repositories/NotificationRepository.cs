
using DataAccessLayer.Abstractions.Repositories;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concretes.Repositories
{
    public class NotificationRepository: GenericRepository<Notification>, INotificationRepository
    {
    }
}
