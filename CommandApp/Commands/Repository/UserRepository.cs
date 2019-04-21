using System;
using System.Linq;
using CommandApp.Entity;

namespace CommandApp.Commands.Repository
{
    public class UserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User FindById(int id)
        {
            return _dbContext.Users.FirstOrDefault(x => x.Id == id);
        }

        public int Create(User user)
        {
           // user.Created = DateTime.Now;
            var entity = _dbContext.Users.Add(user);

            _dbContext.SaveChanges();
            return entity.Entity.Id;
        }

        public void Update(User user)
        {
        }

        public void SaveChanges() {
            _dbContext.SaveChanges();
        }

        public void Delete(User user)
        {
            
        }
    }
}