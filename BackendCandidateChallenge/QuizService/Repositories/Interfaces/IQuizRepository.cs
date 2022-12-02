using QuizService.Model.Domain;
using System.Collections.Generic;

namespace QuizService.Repositories.Interfaces
{
    public interface IQuizRepository
    {
        IEnumerable<Quiz> GetQuizes();
        Quiz GetQuizById(int id);
    }
}
