using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseLibrary.API.DbContexts;
using CourseLibrary.API.Entities;

namespace CourseLibrary.API.Services
{
    public class ComplaintDetailRepository : IComplaintDetailRepository, IDisposable
    {
        private readonly CourseLibraryContext _context;

        public ComplaintDetailRepository(CourseLibraryContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose resources when needed
            }
        }

        public IEnumerable<ComplaintDetail> GetComplaintDetails(string emailAddress)
        {
            if (string.IsNullOrEmpty(emailAddress))
            {
                throw new ArgumentNullException(nameof(emailAddress));
            }

            return _context.ComplaintDetails
                        .Where(c => c.EmailAddress == emailAddress)
                        .OrderBy(c => c.LastModifiedDate).ToList();
        }
    }
}
