using Dapper;
using QuizService.Model.Domain;
using QuizService.Repositories.Interfaces;
using System.Collections.Generic;
using System.Data;

namespace QuizService.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly IDbConnection _connection;

        public QuestionRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Question> GetQuestions(int quizId)
        {
            string sql = $"SELECT * FROM Question WHERE QuizId = {quizId};";
            var questions = _connection.Query<Question>(sql);
            return questions;
        }
    }
}
