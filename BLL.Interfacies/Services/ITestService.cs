﻿using BLL.Interfacies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfacies.Services
{
    public interface ITestService
    {
        TestEntity GetTestEntity(int id);
        IEnumerable<TestEntity> GetAllTestEntity();
        void Update(TestEntity entity);
        void Delete(int id);
    }
}
