﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiTests.Domain.Model;

namespace ApiTests.Domain
{
    public class MenuServiceGroupEntity : SubEntity<MenuServiceGroupProperties, EmbeddedLink>
    {

    }


    public class MenuServiceGroupProperties
    {
        public int GroupId { get; set; }

        public Guid ExternalId { get; set; }

        public string Name { get; set; }

        public int CustomerId { get; set; }

        public DateTime DateCreatedUtc { get; set; }

        public DateTime DateUpdatedUtc { get; set; }

        public string UpdatedByExternalId { get; set; }

        public string CreatedByExternalId { get; set; }
    }
}