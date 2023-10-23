using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        Library_DB db = new Library_DB();

        private LibraryGenericRepository<LibraryBook> bookRepository;
        private LibraryGenericRepository<LibraryBookCategory> bookCategoryRepository;

        public LibraryGenericRepository<LibraryBook> BookRepository
        {
            get
            {
                if (bookRepository == null)
                {
                    bookRepository = new LibraryGenericRepository<LibraryBook>(db);
                }
                return bookRepository;
            }
        }

        public LibraryGenericRepository<LibraryBookCategory> BookCategoryRepository
        {
            get
            {
                if (bookCategoryRepository == null)
                {
                    bookCategoryRepository = new LibraryGenericRepository<LibraryBookCategory>(db);
                }
                return bookCategoryRepository;
            }
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
