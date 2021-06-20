using Complaints.Core.Models;
using Complaints.Data;
using Complaints.Repository.Interfaces;

namespace Complaints.Repository.Implementations
{
    public class ClaimTypeRepository : BaseRepository<ClaimType>, IClaimTypeRepository
    {
        public ClaimTypeRepository(ApplicationDbContext database) : base(database) { }
    }
}
