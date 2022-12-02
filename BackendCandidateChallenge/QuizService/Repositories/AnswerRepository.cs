using Dapper;
using QuizService.Model.Domain;
using QuizService.Repositories.Interfaces;
using System.Collections.Generic;
using System.Data;

namespace QuizService.Repositories
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly IDbConnection _connection;

        public AnswerRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Answer> GetAnswers(int questionId)
        {
            string sql = $"SELECT * FROM Answer WHERE QuestionId = {questionId};";
            var answers = _connection.Query<Answer>(sql);
            return answers;
        }
    }
}
