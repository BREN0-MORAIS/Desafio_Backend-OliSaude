using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliSaude.Domain.Entities
{
    public class Costumer : BaseEntity
    {
      
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public char Sex { get; set; }
        public HealthProblem HealthProblem { get; set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime UpdateDate { get; private set; }
    }
}
