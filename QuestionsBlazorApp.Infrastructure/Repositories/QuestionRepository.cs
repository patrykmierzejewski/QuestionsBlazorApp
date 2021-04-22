using QuestionsBlazorApp.Application.Interface;
using QuestionsBlazorApp.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuestionsBlazorApp.Infrastructure.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly Context _context;

        public QuestionRepository(Context context)
        {
            _context = context;
        }

        #region GET with Context
        public IQueryable<Answer> GetAnswersByQuestionId(int questionId)
        {
            return _context.Answers.Where(x => x.QuestionId == questionId);
        }
        public Answer GetAnswerById(int answerID)
        {
            return _context.Answers.FirstOrDefault(x => x.AnswerId == answerID);
        }
        #endregion
    }
}
