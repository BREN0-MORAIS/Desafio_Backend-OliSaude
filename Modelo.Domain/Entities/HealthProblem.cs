using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliSaude.Domain.Entities
{
    public class HealthProblem : BaseEntity
    {
        public string Name { get; set; }
        public int degree { get; set; }
    }
}
