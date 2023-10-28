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

        private LibraryGenericRepository<tblBook> bookRepository;
        private LibraryGenericRepository<tblCategory> categoryRepository;
        private LibraryGenericRepository<tblUser> userRepository;
        private LibraryGenericRepository<tblComment> commentRepository;
        private LibraryGenericRepository<tblBookCategory> bookCategoryRepository;

        public LibraryGenericRepository<tblCategory> CategoryRepository
        {
            get
            {
                if (categoryRepository == null)
                {
                    categoryRepository = new LibraryGenericRepository<tblCategory>(db);
                }
                return categoryRepository;
            }
        }

        public LibraryGenericRepository<tblComment> CommentRepository
        {
            get
            {
                if (commentRepository == null)
                {
                    commentRepository = new LibraryGenericRepository<tblComment>(db);
                }
                return commentRepository;
            }
        }
        public LibraryGenericRepository<tblBook> BookRepository
        {
            get
            {
                if (bookRepository == null)
                {
                    bookRepository = new LibraryGenericRepository<tblBook>(db);
                }
                return bookRepository;
            }
        }

        public LibraryGenericRepository<tblBookCategory> BookCategoryRepository
        {
            get
            {
                if (bookCategoryRepository == null)
                {
                    bookCategoryRepository = new LibraryGenericRepository<tblBookCategory>(db);
                }
                return bookCategoryRepository;
            }
        }

        public LibraryGenericRepository<tblUser> UserRepository
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new LibraryGenericRepository<tblUser>(db);
                }
                return userRepository;
            }
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
