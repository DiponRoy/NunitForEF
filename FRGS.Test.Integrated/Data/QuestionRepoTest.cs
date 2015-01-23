using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FRGS.Data.Contracts;
using FRGS.Data.Repositories;
using FRGS.Db;
using FRGS.Db.Contracts;
using NUnit.Framework;

namespace FRGS.Test.Integrated.Data
{
    [TestFixture]
    public class QuestionRepoTest
    {
        private IForgeSqlContext _db;
        private IQuestionSetRepo _repo;

        [TestFixtureSetUp]
        public void FixtureStartUp()
        {
            _db = new ForgeSqlContext();
            _repo = new QuestionSetRepo(_db);
        }

        [Test]
        public void IsNameUsed()
        {
            bool isUsed = _repo.IsNameUsed("Practice Problems");
            Assert.AreEqual(true, isUsed);
        }
    }
}
