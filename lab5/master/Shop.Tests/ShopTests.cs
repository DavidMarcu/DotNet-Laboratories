using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Shop.Tests
{
    [TestClass]
    public class ProductTests
    {
        private readonly UnitOfWork uow;

        public ProductTests()
        {
            uow = new UnitOfWork();
        }

        [TestInitialize]
        public void Init()
        {
            // nothing to set up
        }

        [TestCleanup]
        public void Cleanup()
        {
            // nothing to clean up
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void TestAuthorFirstNameMinLength()
        {
            var a = new Author("ion", "popescu");
            uow.AuthorRepository.Insert(a);
        }

        [TestMethod]
        public void TestAuthorAdd()
        {
            var a = new Author("ionuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu", "popescu");
            uow.AuthorRepository.Insert(a);
        }

        [TestMethod]
        public void TestAuthorRemove()
        {
            var x = uow.AuthorRepository.Get().First();
            uow.AuthorRepository.Delete(x.Id);
        }

        [TestMethod]
        public void TestBookAdd()
        {
            var x = uow.AuthorRepository.Get().First();
            var b = new Book("book11111111111111111111111111111111111111111111111111", x);
            uow.BookRepository.Insert(b);
        }

        [TestMethod]
        public void TestBookRemove()
        {
            var x = uow.BookRepository.Get().First();
            uow.BookRepository.Delete(x.Id);
        }
    }
}
