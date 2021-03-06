﻿using BLL.Interfacies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfacies.Services
{
    public interface IUserAnswerService
    {
        ISessionUserAnswerService CreateNewSessionAnswer();
        int EndTest(ISessionUserAnswerService result);
        UserAnswerEntity GetUserAnswerEntityByResultIdAndQuestionId(int resultId, int questionId);

    }
}
