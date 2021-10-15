using KetoBlog.Data;
using KetoBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace KetoBlog.Repositories
{
    public class CommentRepository : IRepository<Comment>
    {
        private ApplicationDbContext _dbContext;

        public CommentRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Comment entity)
        {
            _dbContext.Comments.Add(entity);
        }

        public void AddRange(IEnumerable<Comment> entities)
        {
            _dbContext.Comments.AddRange(entities);
        }

        public IEnumerable<Comment> Find(Expression<Func<Comment, bool>> expression)
        {
            return _dbContext.Comments.Where(expression);
        }

        public IEnumerable<Comment> GetAll()
        {
            return _dbContext.Comments;
        }

        public Comment GetById(int id)
        {
            return _dbContext.Comments.Find(id);
        }

        public void Remove(Comment entity)
        {
            _dbContext.Comments.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Comment> entities)
        {
            _dbContext.Comments.RemoveRange(entities);
        }
    }
}
