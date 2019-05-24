using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.dao
{
    public class ComponentDetailDao
    {
        SOPDbContext _dbContext = null;

        public ComponentDetailDao()
        {
            this._dbContext = new SOPDbContext();
        }
        public int Add(ComponentDetail entity)
        {
            _dbContext.ComponantDetails.Add(entity);
            _dbContext.SaveChanges();
            return entity.ID;
        }
        public bool Update(ComponentDetail entity)
        {
            try
            {
                var ComponantDetail = _dbContext.ComponantDetails.Find(entity.ID);
                ComponantDetail.Name = entity.Name;
                ComponantDetail.Code = entity.Code;
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //logging
                return false;
            }

        }
        public ComponentDetail GetById()
        {
            return _dbContext.ComponantDetails.SingleOrDefault();
        }
        public bool Delete(int id)
        {
            try
            {
                var user = _dbContext.ComponantDetails.Find(id);
                _dbContext.ComponantDetails.Remove(user);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public IEnumerable<ComponentDetail> ListAll()
        {
            return _dbContext.ComponantDetails.ToList();
        }
    }
}
