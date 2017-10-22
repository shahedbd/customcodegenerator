using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FXTF.CRM.Common.Log;
using FXTF.CRM.Service.Admin.Interfaces;
using FXTF.CRM.Data.Repositories.Implementations;
using FXTF.CRM.Model.Model.Admin;

namespace FXTF.CRM.Service.Admin.Implementations
{


public class personalinfoBL : IpersonalinfoBL
{

protected ILogger Logger { get; set; }

public personalinfoBL(ILogger logger)
{
Logger = logger;
}

/// <summary>
/// Insert personalinfo
/// </summary>
/// <param name="entity"></param>
/// <returns>Message</returns>
public async Task<string> Insert(personalinfo entity)
{
try
{
var result = await new personalinfoRepository(logger).Insert(entity);
return result;
}
catch (Exception ex)
{
Logger.Error(ex.Message);
throw ex;
}
}

/// <summary>
/// Update personalinfo
/// </summary>
/// <param name="entity"></param>
/// <returns>Message</returns>
public async Task<string> Update(personalinfo entity)
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
/// Delete personalinfo
/// </summary>
/// <param name="ID"></param>
/// <returns>Message</returns>
public async Task<string> Delete(long ID)
{
try
{
var result = await new personalinfoRepository(logger).Delete(ID);
return result;
}
catch (Exception ex)
{
Logger.Error(ex.Message);
throw ex;
}
}

/// <summary>
/// Get All personalinfo
/// </summary>
/// <returns>List ofpersonalinfo</returns>
public async Task<IEnumerable<personalinfo>> GetAll()
{
try
{
var result = await new personalinfoRepository(logger).GetAll();
return result;
}
catch (Exception ex)
{
Logger.Error(ex.Message);
throw ex;
}
}

/// <summary>
/// Get personalinfo by ID
/// </summary>
/// <param name="ID"></param>
/// <returns>personalinfo Object</returns>
public async Task<personalinfo> GetpersonalinfoByID(long ID)
{
try
{
var result = await new personalinfoRepository(logger).GetpersonalinfoByID(ID);
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
