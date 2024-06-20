using TaskManagerWeb.Models;

namespace TaskManagerWeb.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);
    }
}
