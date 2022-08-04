using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;

namespace LeaveManagement.Web.Repositories
{
    public class LeaveTypeRepository : GenericRepositories<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
