using QuizService.Model.Domain;
using System.Collections.Generic;

namespace QuizService.Repositories.Interfaces
{
    public interface IQuestionRepository
    {
        IEnumerable<Question> GetQuestions(int quizId);
    }
}
