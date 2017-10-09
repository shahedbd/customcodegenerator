using System;
namespace FXTF.CRM.Model.Model.Admin
{
    public class customer_configuration
    {
      public long customer_configuration_id { get; set; }
      public  customer_name { get; set; }
      public int customer_group_id { get; set; }
      public int bill_cycle_date { get; set; }
      public  sold_by { get; set; }
      public DateTime sf_request_date { get; set; }
      public DateTime active_from_date { get; set; }
      public  customer_email_address1 { get; set; }
      public  customer_email_address2 { get; set; }
      public  customer_email_address3 { get; set; }
      public  account_manager_email { get; set; }
      public  std_or_advanced { get; set; }
      public int active { get; set; }
      public int bespoke_rules { get; set; }
      public  daily_or_weekly { get; set; }
      public  shared_bundle_size_gb { get; set; }
    }
}
