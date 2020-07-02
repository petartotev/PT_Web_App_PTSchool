﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static MvcSchool.Data.Models.DataModelsValidations.Mark;

namespace MvcSchool.Data.Models
{
    public class Mark
    {
        public int Id { get; set; }
             
        public EnumValueMark ValueMark { get; set; }

        [MaxLength(MaxLengthTitle)]
        public string Title { get; set; }

        [MaxLength(MaxLengthComment)]
        public string Comment { get; set; }

        public DateTime DateReceived { get; set; }
        public DateTime DateConfirmed { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }    
}
