using xxXXXxxx.xxXXXxxx.ru.Context;
using xxXXXxxx.xxXXXxxx.ru.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace xxXXXxxx.xxXXXxxx.ru.Helpers
{
    public static class EmployeeHelper
    {
        public static async Task<string> GetMotherOrgAsync(SupportWebContext db, Employee person)
        {
            var orgsList = new List<string>();
            var parentOrgId = person.EmpOrg;
            string? parentOrgName;
            while(String.IsNullOrWhiteSpace(Convert.ToString(db.Orgs.Where(x=> x.OrgId == parentOrgId).Select(y=> y.OrgId).First().ToString() ?? null)) == false)
            {
                parentOrgId = await db.Orgs.AsNoTracking().Where(x => x.OrgId == parentOrgId).Select(y => y.OrgParentOrgId).FirstAsync() ?? null;
                if (String.IsNullOrWhiteSpace(parentOrgId.ToString()))
                {
                    break;
                }
                parentOrgName = await db.Orgs.AsNoTracking().Where(x => x.OrgId == parentOrgId).Select(e => e.OrgName).FirstAsync() ?? null;
                orgsList.Add(parentOrgName);
            }

            return orgsList[(orgsList.Count() > 1) ? (orgsList.Count() - 2) : orgsList.Count()];
        }
    }
}
