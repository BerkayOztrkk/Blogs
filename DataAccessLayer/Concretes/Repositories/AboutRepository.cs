using DataAccessLayer.Abstractions.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Concretes.Repositories
{
    public class AboutRepository:GenericRepository<About>, IAboutRepository
    {
    }
}
