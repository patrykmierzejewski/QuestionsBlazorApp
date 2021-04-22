using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionsBlazorApp.Infrastructure.Model
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string QuestionValue { get; set; }

        public virtual List<Answer> AnswersList { get; set; }
    }
}
