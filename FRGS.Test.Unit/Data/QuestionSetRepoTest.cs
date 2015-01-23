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
    public class QuestionSetRepoTest
    {
        private IForgeSqlContext _db;
        private IQuestionSetRepo _repo;

        [TestFixtureSetUp]
        public void FixtureStartUp()
        {
            _db = new FakeForgeSqlContext();
            _db.QuestionSet = new FakeDbSet<QuestionSet>()
            {
                new QuestionSet(){Id = 1, Name = "Practice Problems"}
            };


            _repo = new QuestionSetRepo(_db);
        }

        [Test]
        public void IsNameUsed()
        {
            bool isUsed = _repo.IsNameUsed("Practice Problems");
            Assert.AreEqual(true, isUsed);
        }

        [Test]
        public void Add()
        {
            var aQuestionSet = new QuestionSet() {Id = 2, Name = "Bla"};
            _repo.Add(aQuestionSet);
            _db.SaveChanges();

            var qsn = _repo.Get(aQuestionSet.Id);
        }
    }
}
