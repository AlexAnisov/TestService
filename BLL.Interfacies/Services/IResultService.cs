﻿using BLL.Interfacies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfacies.Services
{
    public interface IResultService
    {
        ResultEntity GetResultEntityById(int id);
        IEnumerable<ResultEntity> GetResultEntityByUserId(int userId);
        ResultEntity GetResultEntityByUserIdAndDate(int userId, DateTime date);
    }
}
