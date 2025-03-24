﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.EF.DAL.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string TopicName { get; set; }

        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
