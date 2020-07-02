﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MvcSchool.Data.Models
{
    public class SubjectTeacher
    {
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
