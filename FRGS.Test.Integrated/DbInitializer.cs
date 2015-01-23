using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FRGS.Db;
using NUnit.Framework;

namespace FRGS.Test.Integrated
{
    [TestFixture]
    public class DbInitializer
    {
        [Test]
        public void CreateSeedDb()
        {
            new Initializer().InitializDefaultDb();
        }

        [Test]
        public void CreateDefaultDb()
        {
            new Initializer().InitializSeededDb();
        }
    }
}
