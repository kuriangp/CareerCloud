using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.EntityFrameworkDataAccess_
{
    class CareerCloudContext: DbContext
    {
        public DbSet<ApplicatioEducationPoco> ApplicationEducation { get; set; }
    }
}
