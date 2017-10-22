using FXTF.CRM.Model.Model.Admin;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FXTF.CRM.Service.Admin.Interfaces
{
    public interface IpersonalinfoBL
    {
Task<string> Insertpersonalinfo(personalinfo entity);
Task<string> Updatepersonalinfo(personalinfo entity);
Task<string> Deletepersonalinfo(personalinfo entity);
Task<IEnumerable<personalinfo>> GetAllpersonalinfo();
Task<personalinfo> GetpersonalinfoByID(long ID)
    }
}
