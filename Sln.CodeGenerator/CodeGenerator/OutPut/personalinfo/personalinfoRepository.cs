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


public class personalinfoRepository : DBOperations<personalinfo>, IRepository<personalinfo>
{

protected ILogger Logger { get; set; }

public personalinfoRepository(ILogger logger)
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
var cmd = new SqlCommand("sp_personalinfo");
cmd.Parameters.AddWithValue("@ID", entity.ID);
cmd.Parameters.AddWithValue("@FirstName", entity.FirstName);
cmd.Parameters.AddWithValue("@LastName", entity.LastName);
cmd.Parameters.AddWithValue("@DateOfBirth", entity.DateOfBirth);
cmd.Parameters.AddWithValue("@City", entity.City);
cmd.Parameters.AddWithValue("@Country", entity.Country);
cmd.Parameters.AddWithValue("@MobileNo", entity.MobileNo);
cmd.Parameters.AddWithValue("@NID", entity.NID);
cmd.Parameters.AddWithValue("@Email", entity.Email);
cmd.Parameters.AddWithValue("@Status", entity.Status);

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
/// Update personalinfo
/// </summary>
/// <param name="entity"></param>
/// <returns>Message</returns>
public async Task<string> Update(personalinfo entity)
{
try
{
var cmd = new SqlCommand("sp_personalinfo");
cmd.Parameters.AddWithValue("@ID", entity.ID);
cmd.Parameters.AddWithValue("@FirstName", entity.FirstName);
cmd.Parameters.AddWithValue("@LastName", entity.LastName);
cmd.Parameters.AddWithValue("@DateOfBirth", entity.DateOfBirth);
cmd.Parameters.AddWithValue("@City", entity.City);
cmd.Parameters.AddWithValue("@Country", entity.Country);
cmd.Parameters.AddWithValue("@MobileNo", entity.MobileNo);
cmd.Parameters.AddWithValue("@NID", entity.NID);
cmd.Parameters.AddWithValue("@Email", entity.Email);
cmd.Parameters.AddWithValue("@Status", entity.Status);

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
/// Delete personalinfo
/// </summary>
/// <param name="ID"></param>
/// <returns>Message</returns>
public async Task<string> Delete(long ID)
{
try
{
var cmd = new SqlCommand("sp_personalinfo");
cmd.Parameters.AddWithValue("@ID", ID);
cmd.Parameters.Add("@Msg", SqlDbType.NChar, 500);


cmd.Parameters["@Msg"].Direction = ParameterDirection.Output;
cmd.Parameters.AddWithValue("@pOptions", 3);


var result = await ExecuteNonQueryProc(cmd);
if (Convert.ToString(result).Trim().Contains("Data Deleted Successfully"))
{
new LiveLogHistoryRepository(logger).Insert(ID.ToString() + " has been Deleted.", 1, 3);
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
/// Get All personalinfo
/// </summary>
/// <returns>List ofpersonalinfo</returns>
public async Task<IEnumerable<personalinfo>> GetAll()
{
try
{
var cmd = new SqlCommand("sp_personalinfo");
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
/// Get personalinfo by ID
/// </summary>
/// <param name="ID"></param>
/// <returns>personalinfo Object</returns>
public async Task<personalinfo> GetpersonalinfoByID(long ID)
{
try
{
var cmd = new SqlCommand("sp_personalinfo");
cmd.Parameters.AddWithValue("@ID", ID);
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
/// Data Mapping for personalinfo
/// </summary>
/// <param name="sqldatareader"></param>
/// <returns>personalinfo Object</returns>
public personalinfo Mapping(SqlDataReader sqldatareader)
{
try
{
personalinfo opersonalinfo = new personalinfo();
opersonalinfo.ID = ColumnExists(reader, "ID") ? ((reader["ID"] == DBNull.Value) ? 0 : Convert.ToInt64(reader["ID"])) : 0 ;
opersonalinfo.FirstName = 
opersonalinfo.LastName = 
opersonalinfo.DateOfBirth = ColumnExists(reader, "DateOfBirth") ? ((reader["DateOfBirth"] == DBNull.Value) ? Convert.ToDateTime("01/01/1900") : Convert.ToDateTime(reader["DateOfBirth"])) : Convert.ToDateTime("01/01/1900");
opersonalinfo.City = 
opersonalinfo.Country = 
opersonalinfo.MobileNo = 
opersonalinfo.NID = 
opersonalinfo.Email = 
opersonalinfo.Status = ColumnExists(reader, "Status") ? ((reader["Status"] == DBNull.Value) ? 0 : Convert.ToInt16(reader["Status"])) : 0 ;
return opersonalinfo;
}
catch (Exception ex)
{
Logger.Error(ex.Message);
throw ex;
}
}


}


}
