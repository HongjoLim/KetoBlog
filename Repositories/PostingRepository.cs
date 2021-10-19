using KetoBlog.Data;
using KetoBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace KetoBlog.Repositories
{
    public class PostingRepository : IRepository<Posting>
    {
        private ApplicationDbContext _dbContext;

        public PostingRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Posting entity)
        {
            _dbContext.Postings.Add(entity);
        }

        public void AddRange(IEnumerable<Posting> entities)
        {
            _dbContext.Postings.AddRange(entities);
        }

        public IEnumerable<Posting> Find(Expression<Func<Posting, bool>> expression)
        {
            return _dbContext.Postings.Where(expression);
        }

        public IEnumerable<Posting> GetAll()
        {
            return _dbContext.Postings;
        }

        public Posting GetById(int id)
        {
            return _dbContext.Postings.Find(id);
        }

        public void Remove(Posting entity)
        {
            _dbContext.Postings.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Posting> entities)
        {
            _dbContext.Postings.RemoveRange(entities);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
