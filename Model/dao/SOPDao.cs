using Model.EF;
using Model.ViewModels;
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

        public MuitipleDataViewModel MultipleData()
        {
            var cCategory = _dbContext.ComponantCategorys.ToList();
            var cDetail = _dbContext.ComponantDetails.ToList();
            var operation = _dbContext.Operations.ToList();
            var modelSOP = _dbContext.SOPModels.ToList();
            var machine = _dbContext.Machines.ToList();
            var treatment = _dbContext.Treatments.ToList();
            var sop = _dbContext.SOPs.ToList();
            MuitipleDataViewModel listMulti = new MuitipleDataViewModel();
            listMulti.ComponentCategories = cCategory;
            listMulti.ComponentDetails = cDetail;
            listMulti.Operations = operation;
            listMulti.SOPModels = modelSOP;
            listMulti.Machines = machine;
            listMulti.Treatments = treatment;
            listMulti.SOPs = sop;
            return listMulti;

        }
    }
}
