using System;
using System.Collections.Generic;
using Xunit;

namespace Interview.Test
{
    public class RepositoryTest
    {
        
       
        [Fact]
        public void GetAllStoreableRecordsFromRepository()
        {
           
        

        IList<IStoreable<int>> storeableList = new List<IStoreable<int>>()
            {
                new Storeable<int>{ Id = 1 },
                new Storeable<int>{ Id = 2 },
                new Storeable<int>{ Id = 3 },
                new Storeable<int>{ Id = 4 },
            };

            IRepository<IStoreable<int>, int> repository = new Repository<IStoreable<int>, int>();
            repository.Save(new Storeable<int> { Id = 1 });
            repository.Save(new Storeable<int> { Id = 2 });
            repository.Save(new Storeable<int> { Id =3 });
            repository.Save(new Storeable<int> { Id = 4 });
                

            Assert.Equal(storeableList, repository.GetAll());

            

        }

        [Fact]
        public void GetStoreableRecordFromRepositoryById()
        {


         
            IRepository<IStoreable<int>, int> repository = new Repository<IStoreable<int>, int>();
            repository.Save(new Storeable<int> { Id = 1 });
            repository.Save(new Storeable<int> { Id = 2 });
            repository.Save(new Storeable<int> { Id = 3 });
            repository.Save(new Storeable<int> { Id = 4 });

            IStoreable<int> expectedResult = new Storeable<int>() { Id = 2 };

            Assert.Equal(expectedResult, repository.Get(2));



        }
        [Fact]
        public void DeleteStoreableRecordFromRepositoryById()
        {


           

            IRepository<IStoreable<int>, int> repository = new Repository<IStoreable<int>, int>();
            repository.Save(new Storeable<int> { Id = 1 });
            repository.Save(new Storeable<int> { Id = 2 });
            repository.Save(new Storeable<int> { Id = 3 });
            repository.Save(new Storeable<int> { Id = 4 });


            repository.Delete(2);

            Assert.Null(repository.Get(2));



        }

        [Fact]
        public void SaveStoreableRecordInRepository()
        {


            IStoreable<int> exptectedResult = new Storeable<int>() { Id = 1 };
            
            IRepository<IStoreable<int>, int> repository = new Repository<IStoreable<int>, int>();

            repository.Save(exptectedResult);

            Assert.Equal(exptectedResult,repository.Get(1));



        }
    }
}
