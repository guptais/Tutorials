using System;
using System.Data.Entity;
using GeekQuiz.Models;

namespace GeekQuiz
{
    public class TriviaDatabaseInitializer<T> : IDatabaseInitializer<T> where T: TriviaDbContext
    {
        public void InitializeDatabase(T context)
        {
            throw new NotImplementedException();
        }
    }
}
