﻿using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.ESN.Models
{
    public class Role : Entity<int>, IAudited
    {
        public string Name { get; set; }
        public string Description { get; set; }


        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
    }
}
