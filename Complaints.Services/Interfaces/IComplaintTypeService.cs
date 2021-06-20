using Complaints.Core.Models;
using Complaints.Repository.Interfaces;

namespace Complaints.Services.Interfaces
{
    public interface IComplaintTypeService : IBaseService<ComplaintType, IComplaintTypeRepository> { }
}
