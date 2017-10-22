using System;
namespace FXTF.CRM.Model.Model.Admin
{
    public class personalinfo
    {
      public long ID { get; set; }
      public  FirstName { get; set; }
      public  LastName { get; set; }
      public DateTime DateOfBirth { get; set; }
      public  City { get; set; }
      public  Country { get; set; }
      public  MobileNo { get; set; }
      public  NID { get; set; }
      public  Email { get; set; }
      public tinyint Status { get; set; }
    }
}
