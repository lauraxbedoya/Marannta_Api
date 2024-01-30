using MaranntaApi.Models;

namespace MaranntaApi.Application.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User Create(User user);
    }
}