using Complaints.Core.Models;
using Complaints.Repository.Interfaces;
using Complaints.Services.Interfaces;

namespace Complaints.Services.Implementations
{
    public class ComplaintTypeService : BaseService<ComplaintType, IComplaintTypeRepository>, IComplaintTypeService
    {
        public ComplaintTypeService(IComplaintTypeRepository complaintTypeRepository) : base(complaintTypeRepository) { }
    }
}
