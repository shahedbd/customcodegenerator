using FXTF.CRM.Model.Model.Admin;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FXTF.CRM.Service.Admin.Interfaces
{
    public interface Icustomer_configurationBL
    {
Task<string> Insertcustomer_configuration(customer_configuration entity);
Task<string> Updatecustomer_configuration(customer_configuration entity);
Task<string> Deletecustomer_configuration(customer_configuration entity);
Task<IEnumerable<customer_configuration>> GetAllcustomer_configuration();
Task<customer_configuration> Getcustomer_configurationBycustomer_configuration_id(long customer_configuration_id)
    }
}
