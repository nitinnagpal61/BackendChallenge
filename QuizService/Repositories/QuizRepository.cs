using Dapper;
using QuizService.Model.Domain;
using QuizService.Repositories.Interfaces;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace QuizService.Repositories
{
    public class QuizRepository : IQuizRepository
    {
        private readonly IDbConnection _connection;

        public QuizRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Quiz> GetQuizes()
        {
            const string sql = "SELECT * FROM Quiz;";
            var quizzes = _connection.Query<Quiz>(sql);
            return quizzes;
        }

        public Quiz GetQuizById(int id)
        {
            string quizSql = $"SELECT * FROM Quiz WHERE Id = {id};";
            var quiz = _connection.QuerySingle<Quiz>(quizSql);
            return quiz;
        }
    }
}
