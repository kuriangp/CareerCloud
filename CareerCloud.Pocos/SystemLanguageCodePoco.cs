﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table ("System_Language_Codes")]
    public class SystemLanguageCodePoco
    {
        [Key]
        [Column ("LanguageID")]
        public Guid LanguageId { get; set; }
        public string Name { get; set; }
        [Column ("Native_Name")]
        public string Native_Name { get; set; }

    }
}
