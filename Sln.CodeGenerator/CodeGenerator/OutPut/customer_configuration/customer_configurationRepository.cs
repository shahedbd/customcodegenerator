using FXTF.CRM.Common.Log;
using FXTF.CRM.Common.Utility;
using FXTF.CRM.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using FXTF.CRM.Data.Repositories.Interfaces;
using FXTF.CRM.Model.Model.Admin;

namespace FXTF.CRM.Data.Repositories.Implementations
{


public class customer_configurationRepository : DBOperations<customer_configuration>, IRepository<customer_configuration>
{

protected ILogger Logger { get; set; }

public customer_configurationRepository(ILogger logger)
{
Logger = logger;
}

/// <summary>
/// Insert customer_configuration
/// </summary>
/// <param name="entity"></param>
/// <returns>Message</returns>
public async Task<string> Insert(customer_configuration entity)
{
try
{
var cmd = new SqlCommand("sp_customer_configuration");
cmd.Parameters.AddWithValue("@customer_configuration_id", entity.customer_configuration_id);
cmd.Parameters.AddWithValue("@customer_name", entity.customer_name);
cmd.Parameters.AddWithValue("@customer_group_id", entity.customer_group_id);
cmd.Parameters.AddWithValue("@bill_cycle_date", entity.bill_cycle_date);
cmd.Parameters.AddWithValue("@sold_by", entity.sold_by);
cmd.Parameters.AddWithValue("@sf_request_date", entity.sf_request_date);
cmd.Parameters.AddWithValue("@active_from_date", entity.active_from_date);
cmd.Parameters.AddWithValue("@customer_email_address1", entity.customer_email_address1);
cmd.Parameters.AddWithValue("@customer_email_address2", entity.customer_email_address2);
cmd.Parameters.AddWithValue("@customer_email_address3", entity.customer_email_address3);
cmd.Parameters.AddWithValue("@account_manager_email", entity.account_manager_email);
cmd.Parameters.AddWithValue("@std_or_advanced", entity.std_or_advanced);
cmd.Parameters.AddWithValue("@active", entity.active);
cmd.Parameters.AddWithValue("@bespoke_rules", entity.bespoke_rules);
cmd.Parameters.AddWithValue("@daily_or_weekly", entity.daily_or_weekly);
cmd.Parameters.AddWithValue("@shared_bundle_size_gb", entity.shared_bundle_size_gb);

cmd.Parameters.Add("@Msg", SqlDbType.NChar, 500);
cmd.Parameters["@Msg"].Direction = ParameterDirection.Output;
cmd.Parameters.AddWithValue("@pOptions", 1);

var result = await ExecuteNonQueryProc(cmd);
return result;
}
catch (Exception ex)
{
Logger.Error(ex.Message);
throw ex;
}
}

/// <summary>
/// Update customer_configuration
/// </summary>
/// <param name="entity"></param>
/// <returns>Message</returns>
public async Task<string> Update(customer_configuration entity)
{
try
{
var cmd = new SqlCommand("sp_customer_configuration");
cmd.Parameters.AddWithValue("@customer_configuration_id", entity.customer_configuration_id);
cmd.Parameters.AddWithValue("@customer_name", entity.customer_name);
cmd.Parameters.AddWithValue("@customer_group_id", entity.customer_group_id);
cmd.Parameters.AddWithValue("@bill_cycle_date", entity.bill_cycle_date);
cmd.Parameters.AddWithValue("@sold_by", entity.sold_by);
cmd.Parameters.AddWithValue("@sf_request_date", entity.sf_request_date);
cmd.Parameters.AddWithValue("@active_from_date", entity.active_from_date);
cmd.Parameters.AddWithValue("@customer_email_address1", entity.customer_email_address1);
cmd.Parameters.AddWithValue("@customer_email_address2", entity.customer_email_address2);
cmd.Parameters.AddWithValue("@customer_email_address3", entity.customer_email_address3);
cmd.Parameters.AddWithValue("@account_manager_email", entity.account_manager_email);
cmd.Parameters.AddWithValue("@std_or_advanced", entity.std_or_advanced);
cmd.Parameters.AddWithValue("@active", entity.active);
cmd.Parameters.AddWithValue("@bespoke_rules", entity.bespoke_rules);
cmd.Parameters.AddWithValue("@daily_or_weekly", entity.daily_or_weekly);
cmd.Parameters.AddWithValue("@shared_bundle_size_gb", entity.shared_bundle_size_gb);

cmd.Parameters.Add("@Msg", SqlDbType.NChar, 500);
cmd.Parameters["@Msg"].Direction = ParameterDirection.Output;
cmd.Parameters.AddWithValue("@pOptions", 2);

var result = await ExecuteNonQueryProc(cmd);
return result;
}
catch (Exception ex)
{
Logger.Error(ex.Message);
throw ex;
}
}

/// <summary>
/// Delete customer_configuration
/// </summary>
/// <param name="customer_configuration_id"></param>
/// <returns>Message</returns>
public async Task<string> Delete(long customer_configuration_id)
{
try
{
var cmd = new SqlCommand("sp_customer_configuration");
cmd.Parameters.AddWithValue("@customer_configuration_id", customer_configuration_id);
cmd.Parameters.Add("@Msg", SqlDbType.NChar, 500);


cmd.Parameters["@Msg"].Direction = ParameterDirection.Output;
cmd.Parameters.AddWithValue("@pOptions", 3);


var result = await ExecuteNonQueryProc(cmd);
if (Convert.ToString(result).Trim().Contains("Data Deleted Successfully"))
{
new LiveLogHistoryRepository(logger).Insert(customer_configuration_id.ToString() + " has been Deleted.", 1, 3);
}
return result;
}
catch (Exception ex)
{
Logger.Error(ex.Message);
throw ex;
}
}

/// <summary>
/// Get All customer_configuration
/// </summary>
/// <returns>List ofcustomer_configuration</returns>
public async Task<IEnumerable<customer_configuration>> GetAll()
{
try
{
var cmd = new SqlCommand("sp_customer_configuration");
cmd.Parameters.AddWithValue("@pOptions", 4);
var result = await GetDataReaderProc(cmd);
return result;
}
catch (Exception ex)
{
Logger.Error(ex.Message);
throw ex;
}
}

/// <summary>
/// Get customer_configuration by customer_configuration_id
/// </summary>
/// <param name="customer_configuration_id"></param>
/// <returns>customer_configuration Object</returns>
public async Task<customer_configuration> Getcustomer_configurationBycustomer_configuration_id(long customer_configuration_id)
{
try
{
var cmd = new SqlCommand("sp_customer_configuration");
cmd.Parameters.AddWithValue("@customer_configuration_id", customer_configuration_id);
cmd.Parameters.AddWithValue("@pOptions", 5);
var result = await GetDataReaderProc(cmd);
return result;
}
catch (Exception ex)
{
Logger.Error(ex.Message);
throw ex;
}
}

/// <summary>
/// Data Mapping for customer_configuration
/// </summary>
/// <param name="sqldatareader"></param>
/// <returns>customer_configuration Object</returns>
public customer_configuration Mapping(SqlDataReader sqldatareader)
{
try
{
customer_configuration ocustomer_configuration = new customer_configuration();
ocustomer_configuration.customer_configuration_id = ColumnExists(reader, "customer_configuration_id") ? ((reader["customer_configuration_id"] == DBNull.Value) ? 0 : Convert.ToInt64(reader["customer_configuration_id"])) : 0 ;
ocustomer_configuration.customer_name = 
ocustomer_configuration.customer_group_id = ColumnExists(reader, "customer_group_id") ? ((reader["customer_group_id"] == DBNull.Value) ? 0 : Convert.ToInt32(reader["customer_group_id"])) : 0 ;
ocustomer_configuration.bill_cycle_date = ColumnExists(reader, "bill_cycle_date") ? ((reader["bill_cycle_date"] == DBNull.Value) ? 0 : Convert.ToInt32(reader["bill_cycle_date"])) : 0 ;
ocustomer_configuration.sold_by = 
ocustomer_configuration.sf_request_date = ColumnExists(reader, "sf_request_date") ? ((reader["sf_request_date"] == DBNull.Value) ? Convert.ToDateTime("01/01/1900") : Convert.ToDateTime(reader["sf_request_date"])) : Convert.ToDateTime("01/01/1900");
ocustomer_configuration.active_from_date = ColumnExists(reader, "active_from_date") ? ((reader["active_from_date"] == DBNull.Value) ? Convert.ToDateTime("01/01/1900") : Convert.ToDateTime(reader["active_from_date"])) : Convert.ToDateTime("01/01/1900");
ocustomer_configuration.customer_email_address1 = 
ocustomer_configuration.customer_email_address2 = 
ocustomer_configuration.customer_email_address3 = 
ocustomer_configuration.account_manager_email = 
ocustomer_configuration.std_or_advanced = 
ocustomer_configuration.active = ColumnExists(reader, "active") ? ((reader["active"] == DBNull.Value) ? 0 : Convert.ToInt32(reader["active"])) : 0 ;
ocustomer_configuration.bespoke_rules = ColumnExists(reader, "bespoke_rules") ? ((reader["bespoke_rules"] == DBNull.Value) ? 0 : Convert.ToInt32(reader["bespoke_rules"])) : 0 ;
ocustomer_configuration.daily_or_weekly = 
ocustomer_configuration.shared_bundle_size_gb = 
return ocustomer_configuration;
}
catch (Exception ex)
{
Logger.Error(ex.Message);
throw ex;
}
}


}


}
