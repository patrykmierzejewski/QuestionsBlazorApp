using QuestionsBlazorApp.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuestionsBlazorApp.Application.Interface
{
    public interface IQuestionRepository
    {
        public IQueryable<Answer> GetAnswersByQuestionId(int questionId);
        public Answer GetAnswerById(int answerID);

    }
}
