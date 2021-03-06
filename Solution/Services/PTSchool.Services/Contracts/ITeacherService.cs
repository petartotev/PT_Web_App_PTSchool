﻿using PTSchool.Services.Contracts;
using PTSchool.Services.Models.Teacher;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PTSchool.Services.Contracts
{
    public interface ITeacherService : IPageable
    {
        Task<IEnumerable<TeacherLightServiceModel>> GetAllTeachersLightByPageAsync(int page = 1);

        Task<TeacherFullServiceModel> GetTeacherFullByIdAsync(Guid id);

        Task<bool> DeleteTeacherByIdAsync(Guid id);

        Task<TeacherFullServiceModel> UpdateTeacherAsync(TeacherFullServiceModel techer);

        Task<TeacherFullServiceModel> CreateTeacherAsync(TeacherFullServiceModel techer);
    }
}
