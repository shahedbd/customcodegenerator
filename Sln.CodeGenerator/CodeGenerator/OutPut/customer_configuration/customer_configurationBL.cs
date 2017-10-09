using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FXTF.CRM.Common.Log;
using FXTF.CRM.Service.Admin.Interfaces;
using FXTF.CRM.Data.Repositories.Implementations;
using FXTF.CRM.Model.Model.Admin;

namespace FXTF.CRM.Service.Admin.Implementations
{


public class customer_configurationBL : Icustomer_configurationBL
{

protected ILogger Logger { get; set; }

public customer_configurationBL(ILogger logger)
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
var result = await new customer_configurationRepository(logger).Insert(entity);
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
var result = await new HoliDayRepository(logger).Update(entity);
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
var result = await new customer_configurationRepository(logger).Delete(customer_configuration_id);
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
var result = await new customer_configurationRepository(logger).GetAll();
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
var result = await new customer_configurationRepository(logger).Getcustomer_configurationBycustomer_configuration_id(customer_configuration_id);
return result;
}
catch (Exception ex)
{
Logger.Error(ex.Message);
throw ex;
}
}


}


}
