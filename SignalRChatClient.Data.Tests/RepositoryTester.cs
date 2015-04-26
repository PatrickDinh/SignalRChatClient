using System;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SignalRChatClient.Domain;

namespace SignalRChatClient.Data.Tests
{
    [TestClass]
    public class RepositoryTester
    {
        public TestContext TestContext { get; set; }
        private IRepository<User> _userRepository;
        private ChatClientDbContext _dbContext;

        [TestInitialize]
        public void Initialize()
        {
            _dbContext = new ChatClientDbContext();
            _dbContext.Database.Create();

            _userRepository = new EfRepository<User>(_dbContext);
        }

        [TestCleanup]
        public void CleanUp()
        {
            _dbContext.Database.Delete();
        }

        public void CreateSampleData()
        {
            _userRepository.Insert(new User
            {
                Id = Guid.NewGuid(),
                NickName = "test1",
                Username = "test1",
                CreatDateTime = DateTime.UtcNow
            });

            _userRepository.Insert(new User
            {
                Id = Guid.NewGuid(),
                NickName = "test2",
                Username = "test2",
                CreatDateTime = DateTime.UtcNow
            });

            _userRepository.Insert(new User
            {
                Id = Guid.NewGuid(),
                NickName = "test3",
                Username = "test3",
                CreatDateTime = DateTime.UtcNow
            });
        }

        [TestMethod]
        public void InsertShouldCreateNewRow()
        {
            var oldCount = _userRepository.TableNoTracking.Count();

            _userRepository.Insert(new User
            {
                Id = Guid.NewGuid(),
                NickName = "test",
                Username = "test"
            });

            var newCount = _userRepository.TableNoTracking.Count();

            Assert.IsTrue(oldCount + 1 == newCount);
        }

        [TestMethod]
        public void InsertShouldCreateRecordWithTheSameId()
        {
            var guid = Guid.NewGuid();

            _userRepository.Insert(new User
            {
                Id = guid,
                NickName = "test",
                Username = "test"
            });

            var r = _userRepository.GetById(guid);
            Assert.AreEqual(r.NickName, "test");
        }

        [TestMethod]
        public void GetWithZeroMatchesShouldReturnNull()
        {
            CreateSampleData();

            var user = _userRepository.GetById(Guid.NewGuid());

            Assert.IsNull(user);
        }
    }
}
