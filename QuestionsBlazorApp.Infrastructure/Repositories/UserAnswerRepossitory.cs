using QuestionsBlazorApp.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuestionsBlazorApp.Infrastructure.Repositories
{
    public class UserAnswerRepossitory : IUserAnswerRepossitory
    {
        private readonly Context _context;
        public UserAnswerRepossitory(Context context)
        {
            _context = context;
        }

        #region Save to db
        public int SetQuestionAnswers(List<UserAnswer> answers)
        {
            _context.UserAnswer.AddRange(answers);
            _context.SaveChanges();
            return answers.FirstOrDefault().UserAnswerId;
        }
        #endregion
    }
}
