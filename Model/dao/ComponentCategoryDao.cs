using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.dao
{
    public class ComponentCategoryDao
    {
        SOPDbContext _dbContext = null;

        public ComponentCategoryDao()
        {
            this._dbContext = new SOPDbContext();
        }
        public int Add(ComponentCategory entity)
        {
            _dbContext.ComponantCategorys.Add(entity);
            _dbContext.SaveChanges();
            return entity.ID;
        }
        public bool Update(ComponentCategory entity)
        {
            try
            {
                var ComponantCategory = _dbContext.ComponantCategorys.Find(entity.ID);
                ComponantCategory.Name = entity.Name;
                ComponantCategory.Code = entity.Code;
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //logging
                return false;
            }

        }
        public ComponentCategory GetById()
        {
            return _dbContext.ComponantCategorys.SingleOrDefault();
        }
        public bool Delete(int id)
        {
            try
            {
                var user = _dbContext.ComponantCategorys.Find(id);
                _dbContext.ComponantCategorys.Remove(user);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public IEnumerable<ComponentCategory> ListAll()
        {
            return _dbContext.ComponantCategorys.ToList();
        }
    }
}
