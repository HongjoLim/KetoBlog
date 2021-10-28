using KetoBlog.Data;
using KetoBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace KetoBlog.Repositories
{
    public class FoodRepository : IRepository<Food>
    {
        private ApplicationDbContext _dbContext;

        public FoodRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Food entity)
        {
            _dbContext.Foods.Add(entity);
        }

        public void AddRange(IEnumerable<Food> entities)
        {
            _dbContext.Foods.AddRange(entities);
        }

        public IEnumerable<Food> Find(Expression<Func<Food, bool>> expression)
        {
            return _dbContext.Foods.Where(expression);
        }

        public IEnumerable<Food> GetAll()
        {
            return _dbContext.Foods;
        }

        public Food GetById(int id)
        {
            return _dbContext.Foods.Find(id);
        }

        public void Remove(Food entity)
        {
            _dbContext.Foods.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Food> entities)
        {
            _dbContext.Foods.RemoveRange(entities);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}