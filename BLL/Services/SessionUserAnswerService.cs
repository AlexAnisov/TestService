using BLL.Interfacies.Entities;
using BLL.Interfacies.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class SessionUserAnswerService: ISessionUserAnswerService
    {
        private List<TmpUserAnswerEntity> tmpUserAnswer = new List<TmpUserAnswerEntity>();
        public void AddTmpItem(int id, int questionId)
        {
            TmpUserAnswerEntity line = tmpUserAnswer
                .Where(p => p.QuestionId == questionId)
                .FirstOrDefault();

            if (line == null)
            {
                tmpUserAnswer.Add(new TmpUserAnswerEntity
                {
                    Id = id,
                    QuestionId= questionId
                });
            }
            else
            {
                tmpUserAnswer.RemoveAll(p => p.QuestionId == questionId);
                tmpUserAnswer.Add(new TmpUserAnswerEntity
                {
                    Id = id
                });
            }
        }

        public void RemoveTmpItem(int id)
        {
            tmpUserAnswer.RemoveAll(p => p.Id == id);
        }

        public void Clear()
        {
            tmpUserAnswer.Clear();
        }
    }
}
