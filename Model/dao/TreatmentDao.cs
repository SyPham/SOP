using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.dao
{
    public class TreatmentDao
    {
        SOPDbContext _dbContext = null;

        public TreatmentDao(SOPDbContext dbContext)
        {
            this._dbContext = new SOPDbContext();
        }
        public int Add(Treatment entity)
        {
            _dbContext.Treatments.Add(entity);
            _dbContext.SaveChanges();
            return entity.ID;
        }
        public bool Update(Treatment entity)
        {
            try
            {
                var Treatment = _dbContext.Treatments.Find(entity.ID);
                Treatment.Name = entity.Name;
                Treatment.Code = entity.Code;
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //logging
                return false;
            }

        }
        public Treatment GetById()
        {
            return _dbContext.Treatments.SingleOrDefault();
        }
        public bool Delete(int id)
        {
            try
            {
                var user = _dbContext.Treatments.Find(id);
                _dbContext.Treatments.Remove(user);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public IEnumerable<Treatment> ListAll()
        {
            return _dbContext.Treatments.ToList();
        }
    }
}
