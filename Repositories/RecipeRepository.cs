using KetoBlog.Data;
using KetoBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace KetoBlog.Repositories
{
    public class RecipeRepository : IRepository<Recipe>
    {
        private ApplicationDbContext _dbContext;

        public RecipeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Recipe entity)
        {
            _dbContext.Recipes.Add(entity);
        }

        public void AddRange(IEnumerable<Recipe> entities)
        {
            _dbContext.Recipes.AddRange(entities);
        }

        public IEnumerable<Recipe> Find(Expression<Func<Recipe, bool>> expression)
        {
            return _dbContext.Recipes.Where(expression);
        }

        public IEnumerable<Recipe> GetAll()
        {
            return _dbContext.Recipes;
        }

        public Recipe GetById(int id)
        {
            return _dbContext.Recipes.Find(id);
        }

        public void Remove(Recipe entity)
        {
            _dbContext.Recipes.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Recipe> entities)
        {
            _dbContext.Recipes.RemoveRange(entities);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}