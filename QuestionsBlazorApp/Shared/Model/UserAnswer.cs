using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionsBlazorApp.Infrastructure.Model
{
    public class UserAnswer
    {
        public int UserAnswerId { get; set; }

        public virtual User User { get; set; }
        public virtual Answer Answer { get; set; }
        public virtual Question Question { get; set; }
    }
}
