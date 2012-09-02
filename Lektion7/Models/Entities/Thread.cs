﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lektion7.Models.Entities.Abstract;

namespace Lektion7.Models.Entities
{
    public class ForumThread : IEntity
    {
        public Guid ID { get; set; }
        public string ThreadName { get; set; }
        public DateTime CreateDate { get; set; }
    }
}