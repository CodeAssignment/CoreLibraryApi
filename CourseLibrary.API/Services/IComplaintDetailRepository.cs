﻿using CourseLibrary.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Services
{
    public interface IComplaintDetailRepository
    {
        IEnumerable<ComplaintDetail> GetComplaintDetails(string emailAddress);


    }
}
