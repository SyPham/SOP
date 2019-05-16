using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.dao
{
    public class MachineDao
    {
        SOPDbContext _dbContext = null;

        public MachineDao(SOPDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public int Add(Machine entity)
        {
            _dbContext.Machines.Add(entity);
            _dbContext.SaveChanges();
            return entity.ID;
        }
        public bool Update(Machine entity)
        {
            try
            {
                var machine = _dbContext.Machines.Find(entity.ID);
                machine.Name = entity.Name;
                machine.Code = entity.Code;
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //logging
                return false;
            }

        }
        public Machine GetById()
        {
            return _dbContext.Machines.SingleOrDefault();
        }
        public bool Delete(int id)
        {
            try
            {
                var user = _dbContext.Machines.Find(id);
                _dbContext.Machines.Remove(user);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        //public IEnumerable<Machine> ListAllPaging(string searchString, int page, int pageSize)
        //{
        //    return "";
        //}
        public IEnumerable<Machine> ListAll()
        {
            return _dbContext.Machines.ToList();
        }
    }
}
