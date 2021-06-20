using Complaints.Core.Models;
using Complaints.Data;
using Complaints.Repository.Interfaces;

namespace Complaints.Repository.Implementations
{
    public class ComplaintTypeRepository : BaseRepository<ComplaintType>, IComplaintTypeRepository
    {
        public ComplaintTypeRepository(ApplicationDbContext database) : base(database) { }
    }
}
