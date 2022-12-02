using QuizService.Model.Domain;
using System.Collections.Generic;

namespace QuizService.Repositories.Interfaces
{
    public interface IAnswerRepository
    {
        IEnumerable<Answer> GetAnswers(int questionId);
    }
}
