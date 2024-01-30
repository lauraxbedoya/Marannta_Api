using Microsoft.EntityFrameworkCore;
using MaranntaApi.Models;
using System.Linq;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MaranntaApi.Application.Interfaces;

namespace MaranntaApi.Applications
{
    public class UserServices : IUserService
    {
        private readonly AppDbContext _context;

        public UserServices(AppDbContext context)
        {
            _context = context;
        }


        public IEnumerable<User> GetAllUsers()
        {
            var users = _context.Users.ToList();
            return users;
        }

        public User Create(User user)
        {
            string password = user.Password;
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

            var userEntity = new User()
            {
                Name = user.Name,
                LastName = user.LastName,
                Email = user.Email,
                Password = passwordHash,
                BirthDate = user.BirthDate,
                Phone = user.Phone,
            };
            _context.Users.Add(userEntity);
            _context.SaveChanges();

            return userEntity;
        }
    }
}