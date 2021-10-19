using KetoBlog.Data;
using KetoBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace KetoBlog.Repositories
{
    public class LikeRepository : IRepository<Like>
    {
        private ApplicationDbContext _dbContext;

        public LikeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Like entity)
        {
            _dbContext.Likes.Add(entity);
        }

        public void AddRange(IEnumerable<Like> entities)
        {
            _dbContext.Likes.AddRange(entities);
        }

        public IEnumerable<Like> Find(Expression<Func<Like, bool>> expression)
        {
            return _dbContext.Likes.Where(expression);
        }

        public IEnumerable<Like> GetAll()
        {
            return _dbContext.Likes;
        }

        public Like GetById(int id)
        {
            return _dbContext.Likes.Find(id);
        }

        public void Remove(Like entity)
        {
            _dbContext.Likes.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Like> entities)
        {
            _dbContext.Likes.RemoveRange(entities);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
