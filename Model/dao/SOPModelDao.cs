using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.dao
{
    public class SOPModelDao
    {
        SOPDbContext _dbContext = null;

        public SOPModelDao()
        {
            this._dbContext = new SOPDbContext();
        }
        public int Add(SOPModel entity)
        {
            _dbContext.SOPModels.Add(entity);
            _dbContext.SaveChanges();
            return entity.ID;
        }
        public bool Update(SOPModel entity)
        {
            try
            {
                var SOPModel = _dbContext.SOPModels.Find(entity.ID);
                SOPModel.Name = entity.Name;
                SOPModel.Code = entity.Code;
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //logging
                return false;
            }

        }
        public SOPModel GetById()
        {
            return _dbContext.SOPModels.SingleOrDefault();
        }
        public bool Delete(int id)
        {
            try
            {
                var user = _dbContext.SOPModels.Find(id);
                _dbContext.SOPModels.Remove(user);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public IEnumerable<SOPModel> ListAll()
        {
            return _dbContext.SOPModels.ToList();
        }
    }
}
