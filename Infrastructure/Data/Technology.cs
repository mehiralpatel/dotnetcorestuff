﻿using System;
using System.Collections.Generic;

namespace Infrastructure.Data
{
    public partial class Technology : BaseEntity
    {
        public Technology()
        {
            Project = new HashSet<Project>();
            ProposalTechnologyMap = new HashSet<ProposalTechnologyMap>();
            Resource = new HashSet<Resource>();
            ResourceTechnologyMap = new HashSet<ResourceTechnologyMap>();
            TechnologySkill = new HashSet<TechnologySkill>();
        }

        public long TechnologyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short Status { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime LastModifiedDateTime { get; set; }
        public int CreatedByUserId { get; set; }
        public int LastModifiedByUserId { get; set; }

        public ICollection<Project> Project { get; set; }
        public ICollection<ProposalTechnologyMap> ProposalTechnologyMap { get; set; }
        public ICollection<Resource> Resource { get; set; }
        public ICollection<ResourceTechnologyMap> ResourceTechnologyMap { get; set; }
        public ICollection<TechnologySkill> TechnologySkill { get; set; }
    }
}
