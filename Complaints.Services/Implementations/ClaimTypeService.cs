using Complaints.Core.Models;
using Complaints.Repository.Interfaces;
using Complaints.Services.Interfaces;

namespace Complaints.Services.Implementations
{
    public class ClaimTypeService : BaseService<ClaimType, IClaimTypeRepository>, IClaimTypeService
    {
        public ClaimTypeService(IClaimTypeRepository claimTypeRepository) : base(claimTypeRepository) { }
    }
}
