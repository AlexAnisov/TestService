using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfacies.Services
{
    public interface ISessionUserAnswerService
    {
        void AddTmpItem(int id, int questionId);
        void RemoveTmpItem(int id);
        void Clear();
    }
}
