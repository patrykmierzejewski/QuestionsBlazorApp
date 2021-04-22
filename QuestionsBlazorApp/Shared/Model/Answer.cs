using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionsBlazorApp.Infrastructure.Model
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerValue { get; set; }
        
        public virtual Question Question { get; set; }
        public virtual int QuestionId { get; set; }
    }
}
