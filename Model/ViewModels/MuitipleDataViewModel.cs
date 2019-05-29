using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModels
{
    public class MuitipleDataViewModel
    {
        public IEnumerable<ComponentCategory> ComponentCategories { get; set; }
        public IEnumerable<ComponentDetail> ComponentDetails { get; set; }
        public IEnumerable<Operation> Operations { get; set; }
        public IEnumerable<SOPModel> SOPModels { get; set; }
        public IEnumerable<Machine> Machines { get; set; }
        public IEnumerable<Treatment> Treatments { get; set; }
        public IEnumerable<SOP> SOPs { get; set; }
    }
}
