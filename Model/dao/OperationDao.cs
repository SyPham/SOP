using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.dao
{
    public class OperationDao
    {
        SOPDbContext _dbContext = null;

        public OperationDao()
        {
            this._dbContext = new SOPDbContext();
        }
        public int Add(Operation entity)
        {
            _dbContext.Operations.Add(entity);
            _dbContext.SaveChanges();
            return entity.ID;
        }
        public bool Update(Operation entity)
        {
            try
            {
                var Operation = _dbContext.Operations.Find(entity.ID);
                Operation.Name = entity.Name;
                Operation.Code = entity.Code;
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //logging
                return false;
            }

        }
        public Operation GetById()
        {
            return _dbContext.Operations.SingleOrDefault();
        }
        public bool Delete(int id)
        {
            try
            {
                var user = _dbContext.Operations.Find(id);
                _dbContext.Operations.Remove(user);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public IEnumerable<Operation> ListAll()
        {
            return _dbContext.Operations.ToList();
        }
    }
}
