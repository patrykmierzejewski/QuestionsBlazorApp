using QuestionsBlazorApp.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionsBlazorApp.Application.Interface
{
    public interface IUserAnswerRepossitory
    {
        public int SetQuestionAnswers(List<UserAnswer> answers);
    }
}
