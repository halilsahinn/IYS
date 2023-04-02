#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Domain.Base;
#endregion

namespace Invo.izin.Yönetim.Sistemi.Domain.Leave
{
    public class LeaveRequestEntity : BaseEntity<int>
    {
        #region CTOR
        public LeaveRequestEntity(int employeeId, DateTime startedDate, DateTime finishedDate, byte leaveTypeId, decimal leaveTime, bool isApproved)
        {
            EmployeeId = employeeId;
            StartedDate = startedDate;
            FinishedDate = finishedDate;
            LeaveTypeId = leaveTypeId;
            LeaveTime = leaveTime;
            IsApproved = isApproved;
          
        }

        #endregion

        #region PROPERTIES
        public int EmployeeId { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime FinishedDate { get; set; }
        public byte LeaveTypeId { get; set; }
        public decimal LeaveTime { get; set; }
        public bool IsApproved { get; set; }
      
        #endregion


    }
}
