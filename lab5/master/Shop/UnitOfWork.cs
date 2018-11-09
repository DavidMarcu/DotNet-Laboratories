using System;

namespace Shop
{
    public class UnitOfWork : IDisposable
    {
        private ApplicationContext context = new ApplicationContext();
        private GenericRepository<Author> authorRepository;
        private GenericRepository<Book> bookRepository;

        public GenericRepository<Author> AuthorRepository
        {
            get
            {

                if (authorRepository == null)
                {
                    authorRepository = new GenericRepository<Author>(context);
                }
                return authorRepository;
            }
        }

        public GenericRepository<Book> BookRepository
        {
            get
            {

                if (bookRepository == null)
                {
                    bookRepository = new GenericRepository<Book>(context);
                }
                return bookRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

}
