using System.Data.Entity;
using System.Linq;
using FRGS.Data.Contracts;
using FRGS.Data.Repositories;
using FRGS.Db;
using FRGS.Db.Contracts;
using FRGS.Model;
using FRGS.Test.Unit.DbContext;
using NUnit.Framework;

namespace FRGS.Test.Unit.Data
{
    [TestFixture]
    public class QuestionRepoTest
    {
        private IForgeSqlContext _db;
        private IQuestionRepo _repo;

        [TestFixtureSetUp]
        public void FixtureStartUp()
        {
            _db = new FakeForgeSqlContext();
            _db.Question = new FakeDbSet<Question>()
            {
                new Question() {Id = 1, Title = "What is the Name.", QuestionSetId = 1, QuestionSet = new QuestionSet() { Id = 1, Name = "set"}}
            };

            _db.QuestionSet = new FakeDbSet<QuestionSet>()
            {
                new QuestionSet() { Id = 1, Name = "set"}
            };



            _repo = new QuestionRepo(_db);
        }


        [Test]
        public void Get()
        {
            var all = _repo.AllWithIncludes().ToList();
            var list = _repo.All();
        }
    }
}
