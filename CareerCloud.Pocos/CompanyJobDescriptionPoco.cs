using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_JobsDescriptions")]
    public class CompanyJobDescriptionPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Job { get; set; }
        [Column("Job_Name")]
        public string JobName { get; set; }
        [Column ("Job_Descriptions")]
        public string JobDescription { get; set; }
        [Column ("Time_Stamp")]
        public byte[] TimeStamp { get; set; }
    }
}
