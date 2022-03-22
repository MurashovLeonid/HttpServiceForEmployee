using System;
using System.Collections.Generic;

namespace xxXXXxxx
{
    /// <summary>
    /// Сотрудники
    /// </summary>
    public partial class Employee
    {
        public Employee()
        {
            Orgs = new HashSet<Org>();
        }

        public Guid EmpId { get; set; }
        public string? EmpTabNumber { get; set; }
        public string? EmpLogin { get; set; }
        public string? EmpFname { get; set; }
        public string? EmpMname { get; set; }
        public string? EmpLname { get; set; }
        public DateTime? EmpBirthday { get; set; }
       
        public string? EmpTitle { get; set; }
       
        public DateTime? FlDeleted { get; set; }
        public DateTime? EmpAdChanged { get; set; }
        public string? EmpAdBlocked { get; set; }
        public DateTime? FlCreated { get; set; }
        public DateTime? FlChanged { get; set; }
        public string? EmpName { get; set; }
        public string? EmpMail { get; set; }
        public Guid? EmpOrg { get; set; }
        public DateTime? EmpLogon { get; set; }
        public string? EmpHomepage { get; set; }
        public string? EmpSex { get; set; }
        public bool EmpPrivate { get; set; }
        public byte[]? EmpNewSupportPhoto { get; set; }
        public int? EmpPriority { get; set; }
        public bool EmpProfSync { get; set; }
        public bool EmpProfSyncError { get; set; }
        public bool EmpTrainingsSync { get; set; }
        public bool EmpTrainingsSyncError { get; set; }
        public string? EmpHostname { get; set; }
        public DateTime? EmpHostnameDate { get; set; }
        public bool? EmpNotShowBeginner { get; set; }
        public bool EmpBeginnerWelcomeSended { get; set; }
        public bool? EmpRemoteRights { get; set; }
        public bool? EmpRemoteConnect { get; set; }
        public bool? EmpRemoteError { get; set; }
        public string? EmpRemoteComment { get; set; }
        public bool? EmpRemoteQuery { get; set; }
        public bool? EmpRemoteReady { get; set; }
        public DateTime? EmpRemoteFrom { get; set; }
        public DateTime? EmpRemoteTill { get; set; }
        public Guid? EmpMainLevelHelpDesk { get; set; }
        public bool EmpInformationSecuritySent { get; set; }
        public DateTime? EmpEmploymentDate { get; set; }
        public int? EmpSentWelcMess { get; set; }
        public bool? EmpNeedWelcMess { get; set; }

        public virtual Org? EmpOrgNavigation { get; set; }
        public virtual ICollection<Org> Orgs { get; set; }
    }
}
