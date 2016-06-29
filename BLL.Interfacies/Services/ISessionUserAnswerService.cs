using BLL.Interfacies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfacies.Services
{
    public interface ISessionUserAnswerService
    {
        bool AddTmpItem(int id, int questionId, bool correct, int cost);
        void RemoveTmpItem(int id);
        void Clear();
        void StartTest(int testId, int time);
        void EndTest();
        IEnumerable<TmpUserAnswerEntity> Result { get; }
        int TestId { get; }
    }
}
