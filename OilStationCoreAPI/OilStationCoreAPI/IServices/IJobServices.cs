﻿using OilStationCoreAPI.Models;
using OilStationCoreAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OilStationCoreAPI.IServices
{
    public interface IJobServices
    {
        ResponseModel<IEnumerable<Job>> Job_Get();
    }
}
