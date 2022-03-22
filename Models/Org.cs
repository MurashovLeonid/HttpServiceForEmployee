using System;
using System.Collections.Generic;

namespace xxXXXxxx
{
    public partial class Org
    {
        public Org()
        {
            Employees = new HashSet<Employee>();
            InverseOrgParentDep = new HashSet<Org>();
            InverseOrgParentOrg = new HashSet<Org>();
        }

        public Guid OrgId { get; set; }
        public string? OrgTabNumber { get; set; }
        /// <summary>
        /// Название отдела
        /// </summary>
        public string? OrgName { get; set; }
        public string? OrgSname { get; set; }
        public string? OrgDescription { get; set; }
        /// <summary>
        /// иерархия отделов по группам
        /// </summary>
        public Guid? OrgGroupId { get; set; }
        /// <summary>
        /// иерархия отделов
        /// </summary>
        public Guid? OrgParentOrgId { get; set; }
        /// <summary>
        /// иерархия департаментов
        /// </summary>
        public Guid? OrgParentDepId { get; set; }
        public byte[]? FlUpdated { get; set; }
        public DateTime? FlDeleted { get; set; }
        public bool OrgHidden { get; set; }
        public bool OrgSkipCode { get; set; }
        public string OrgTitle { get; set; } = null!;
        public string OrgCode { get; set; } = null!;
        public Guid? OrgBoss { get; set; }
        public int OrgOrder { get; set; }

        public virtual Employee? OrgBossNavigation { get; set; }
        public virtual Org? OrgParentDep { get; set; }
        public virtual Org? OrgParentOrg { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Org> InverseOrgParentDep { get; set; }
        public virtual ICollection<Org> InverseOrgParentOrg { get; set; }
    }
}
