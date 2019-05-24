using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.dao
{
    public class SOPDao
    {
        SOPDbContext _dbContext = null;

        public SOPDao()
        {
            this._dbContext = new SOPDbContext();
        }
        public int Add(SOP entity)
        {
            _dbContext.SOPs.Add(entity);
            _dbContext.SaveChanges();
            return entity.ID;
        }
        public bool Update(SOP entity)
        {
            try
            {
                var SOP = _dbContext.SOPs.Find(entity.ID);
                SOP.Name = entity.Name;
                SOP.Code = entity.Code;
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //logging
                return false;
            }

        }
        public SOP GetById()
        {
            return _dbContext.SOPs.SingleOrDefault();
        }
        public bool Delete(int id)
        {
            try
            {
                var user = _dbContext.SOPs.Find(id);
                _dbContext.SOPs.Remove(user);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public IEnumerable<SOP> ListAll()
        {
            return _dbContext.SOPs.ToList();
        }
    }
}
