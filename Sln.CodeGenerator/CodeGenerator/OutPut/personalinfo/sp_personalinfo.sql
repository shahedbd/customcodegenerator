SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  proc [dbo].[sp_personalinfo]
(
@ID		bigint = null,
@FirstName		nchar(100) = null,
@LastName		nchar(100) = null,
@DateOfBirth		datetime = null,
@City		nchar(50) = null,
@Country		nchar(100) = null,
@MobileNo		nchar(50) = null,
@NID		nchar(100) = null,
@Email		nchar(100) = null,
@Status		tinyint = null,

@Msg				nvarchar(MAX)=null OUT ,
@pOptions			int 
)
AS
--Save personalinfo
if(@pOptions=1)
begin
INSERT INTO personalinfo
(
ID,
FirstName,
LastName,
DateOfBirth,
City,
Country,
MobileNo,
NID,
Email,
Status

)
VALUES
(	
@ID,
@FirstName,
@LastName,
@DateOfBirth,
@City,
@Country,
@MobileNo,
@NID,
@Email,
@Status

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
--End of Save personalinfo



--Update personalinfo 
if(@pOptions=2)
begin
UPDATE	personalinfo 
SET
FirstName	=	@FirstName ,
LastName	=	@LastName ,
DateOfBirth	=	@DateOfBirth ,
City	=	@City ,
Country	=	@Country ,
MobileNo	=	@MobileNo ,
NID	=	@NID ,
Email	=	@Email ,
Status	=	@Status 




WHERE	ID	=	@ID;



IF @@ROWCOUNT = 0
Begin
SET @Msg='Warning: No rows were Updated';	
End
Else
Begin
SET @Msg='Data Updated Successfully';
End
End
--End of Update personalinfo 



--Delete personalinfo



if(@pOptions=3)
begin
Delete from personalinfo Where ID=@ID;
SET @Msg='Data Deleted Successfully';
end



--End of Delete personalinfo 



--Select All personalinfo 



if(@pOptions=4)
begin	        
select * from personalinfo;
if(@@ROWCOUNT=0)
SET @Msg='Data Not Found';
end



--End of Select All personalinfo 



--Select personalinfo By ID 
if(@pOptions=5)
begin
select * from personalinfo Where ID=@ID;



if(@@ROWCOUNT=0)
SET @Msg='Data Not Found';
end
--End of Select personalinfo By ID 
