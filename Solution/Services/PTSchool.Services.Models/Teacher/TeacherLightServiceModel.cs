﻿using System;

namespace PTSchool.Services.Models.Teacher
{
    public class TeacherLightServiceModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }

        public bool IsHeadTeacher { get; set; }

        public bool IsDeleted { get; set; }
        public bool IsBanned { get; set; }
    }
}
