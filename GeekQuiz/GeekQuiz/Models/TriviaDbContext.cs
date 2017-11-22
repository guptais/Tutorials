using Microsoft.Data.Entity;
using Microsoft.EntityFrameworkCore;
using DbContext = System.Data.Entity.DbContext;

namespace GeekQuiz.Models
{
    public class TriviaDbContext : DbContext
    {
        private static bool _created = false;

        public TriviaDbContext()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureCreated();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TriviaOption>()
                .HasKey(o => new { o.QuestionId, o.Id });

            builder.Entity<TriviaAnswer>()
                .HasOne(a => a.TriviaOption)
                .WithMany()
                .HasForeignKey(a => new { a.QuestionId, a.OptionId });

            builder.Entity<TriviaQuestion>()
                .HasMany(q => q.Options)
                .WithOne(o => o.TriviaQuestion);
        }
        
        public System.Data.Entity.DbSet<TriviaQuestion> TriviaQuestions { get; set; }

        public System.Data.Entity.DbSet<TriviaOption> TriviaOptions { get; set; }

        public System.Data.Entity.DbSet<TriviaAnswer> TriviaAnswers { get; set; }
    }
}
