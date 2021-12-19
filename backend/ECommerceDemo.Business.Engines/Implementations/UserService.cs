using AutoMapper;
using ECommerceDemo.Business.Engines.Interfaces;
using ECommerceDemo.Core.Entities;
using ECommerceDemo.Core.UnitOfWork;
using ECommerceDemo.Data.DAL;
using ECommerceDemo.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ECommerceDemo.Business.Engines.Implementations
{
    public class UserService : IUserService
    {
        private readonly EFContext _context;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper, EFContext context)
        {
            _context = context;
        }
        public void Add(User user)
        {
            _context.Set<User>().Add(user);
            _context.SaveChanges();
        }

        public User GetByMail(string email)
        {
            return _context.Set<User>().Where(u => u.Email == email).FirstOrDefault();
        }

        public List<Role> GetClaims(User user)
        {
            var result = from role in _context.Roles
                         join userRole in _context.UserRoles
                             on role.Id equals userRole.RoleId
                         where userRole.UserId == user.Id
                         select new Role { Id = role.Id, Name = role.Name };
            return result.ToList();
        }
    }
}
