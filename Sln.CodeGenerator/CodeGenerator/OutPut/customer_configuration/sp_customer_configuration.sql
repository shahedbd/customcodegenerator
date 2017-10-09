SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  proc [dbo].[sp_customer_configuration]
(
@customer_configuration_id		bigint = null,
@customer_name		varchar = null,
@customer_group_id		int = null,
@bill_cycle_date		int = null,
@sold_by		varchar = null,
@sf_request_date		datetime = null,
@active_from_date		datetime = null,
@customer_email_address1		varchar = null,
@customer_email_address2		varchar = null,
@customer_email_address3		varchar = null,
@account_manager_email		varchar = null,
@std_or_advanced		varchar = null,
@active		int = null,
@bespoke_rules		int = null,
@daily_or_weekly		varchar = null,
@shared_bundle_size_gb		varchar = null,

@Msg				nvarchar(MAX)=null OUT ,
@pOptions			int 
)
AS
--Save customer_configuration
if(@pOptions=1)
begin
INSERT INTO customer_configuration
(
customer_configuration_id,
customer_name,
customer_group_id,
bill_cycle_date,
sold_by,
sf_request_date,
active_from_date,
customer_email_address1,
customer_email_address2,
customer_email_address3,
account_manager_email,
std_or_advanced,
active,
bespoke_rules,
daily_or_weekly,
shared_bundle_size_gb

)
VALUES
(	
@customer_configuration_id,
@customer_name,
@customer_group_id,
@bill_cycle_date,
@sold_by,
@sf_request_date,
@active_from_date,
@customer_email_address1,
@customer_email_address2,
@customer_email_address3,
@account_manager_email,
@std_or_advanced,
@active,
@bespoke_rules,
@daily_or_weekly,
@shared_bundle_size_gb

)
IF @@ROWCOUNT = 0
Begin
SET @Msg='Warning: No rows were Inserted';	
End
Else
Begin
SET @Msg='Data Saved Successfully';	
End					
end
--End of Save customer_configuration



--Update customer_configuration 
if(@pOptions=2)
begin
UPDATE	customer_configuration 
SET
customer_name	=	@customer_name ,
customer_group_id	=	@customer_group_id ,
bill_cycle_date	=	@bill_cycle_date ,
sold_by	=	@sold_by ,
sf_request_date	=	@sf_request_date ,
active_from_date	=	@active_from_date ,
customer_email_address1	=	@customer_email_address1 ,
customer_email_address2	=	@customer_email_address2 ,
customer_email_address3	=	@customer_email_address3 ,
account_manager_email	=	@account_manager_email ,
std_or_advanced	=	@std_or_advanced ,
active	=	@active ,
bespoke_rules	=	@bespoke_rules ,
daily_or_weekly	=	@daily_or_weekly ,
shared_bundle_size_gb	=	@shared_bundle_size_gb 




WHERE	customer_configuration_id	=	@customer_configuration_id;



IF @@ROWCOUNT = 0
Begin
SET @Msg='Warning: No rows were Updated';	
End
Else
Begin
SET @Msg='Data Updated Successfully';
End
End
--End of Update customer_configuration 



--Delete customer_configuration



if(@pOptions=3)
begin
Delete from customer_configuration Where customer_configuration_id=@customer_configuration_id;
SET @Msg='Data Deleted Successfully';
end



--End of Delete customer_configuration 



--Select All customer_configuration 



if(@pOptions=4)
begin	        
select * from customer_configuration;
if(@@ROWCOUNT=0)
SET @Msg='Data Not Found';
end



--End of Select All customer_configuration 



--Select customer_configuration By customer_configuration_id 
if(@pOptions=5)
begin
select * from customer_configuration Where customer_configuration_id=@customer_configuration_id;



if(@@ROWCOUNT=0)
SET @Msg='Data Not Found';
end
--End of Select customer_configuration By customer_configuration_id 
