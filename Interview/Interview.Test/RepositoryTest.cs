using System;
using System.Collections.Generic;
using Xunit;

namespace Interview.Test
{
    public class RepositoryTest
    {
        
        /// <summary>
        /// Test method to  GetAll
        /// </summary>
       
        [Fact]
        public void GetAllStoreableRecordsFromRepository()
        {

        
            IRepository<IStoreable<int>, int> repository = MemoryRepositoryFactory<IStoreable<int>, int>.Create<IStoreable<int>, int>();
           
            repository.Save(new Storeable<int> { Id = 1 });
            repository.Save(new Storeable<int> { Id = 2 });
            repository.Save(new Storeable<int> { Id = 3 });
            repository.Save(new Storeable<int> { Id = 4 });


            Assert.Collection(repository.GetAll(), item => item.Id = 1, item => item.Id = 2, item => item.Id = 3, item => item.Id = 4)
;
            
        }

        /// <summary>
        /// Test method to Get record by Id
        /// </summary>

        [Fact]
        public void GetStoreableRecordFromRepositoryById()
        {

            IRepository<IStoreable<int>, int> repository = MemoryRepositoryFactory<IStoreable<int>, int>.Create<IStoreable<int>, int>();

            repository.Save(new Storeable<int> { Id = 1 });
            repository.Save(new Storeable<int> { Id = 2 });
            repository.Save(new Storeable<int> { Id = 3 });
            repository.Save(new Storeable<int> { Id = 4 });

            IStoreable<int> expectedResult = new Storeable<int>() { Id = 2 };

            Assert.Equal(expectedResult.Id, repository.Get(2).Id);

            
        }

        /// <summary>
        /// Test method of Delete form repository
        /// </summary>
        [Fact]
        public void DeleteStoreableRecordFromRepositoryById()
        {
            
            IRepository<IStoreable<int>, int> repository = MemoryRepositoryFactory<IStoreable<int>, int>.Create<IStoreable<int>, int>();

            repository.Save(new Storeable<int> { Id = 1 });
            repository.Save(new Storeable<int> { Id = 2 });
            repository.Save(new Storeable<int> { Id = 3 });
            repository.Save(new Storeable<int> { Id = 4 });


            repository.Delete(2);

            Assert.Null(repository.Get(2));
            

        }
        /// <summary>
        /// Test method to Save repository 
        /// </summary>
        [Fact]
        public void SaveStoreableRecordInRepository()
        {
            
            IStoreable<int> exptectedResult = new Storeable<int>() { Id = 1 };

            IRepository<IStoreable<int>, int> repository = MemoryRepositoryFactory<IStoreable<int>, int>.Create<IStoreable<int>, int>();
            
            repository.Save(exptectedResult);

            Assert.Equal(exptectedResult,repository.Get(1));

            
        }
    }
}
