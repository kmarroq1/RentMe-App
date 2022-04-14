CREATE OR ALTER PROCEDURE RegisterMember
	( @FirstName VARCHAR(45)
	, @LastName VARCHAR(45)
	, @BirthDate DATE
	, @Address1 VARCHAR(45)
	, @Address2 VARCHAR(45)
	, @City VARCHAR(45)
	, @State VARCHAR(45)
	, @Zip VARCHAR(20)
	, @Phone VARCHAR(45)
	, @Active BIT
	)
AS
BEGIN
	INSERT INTO [storeMember]
		( [Fname]
		, [Lname]
		, [BirthDate]
		, [Address1]
		, [Address2]
		, [City]
		, [State]
		, [Zip]
		, [Phone]
		, [Active]
		)
	VALUES
		( @FirstName
		, @LastName
		, @BirthDate
		, @Address1
		, @Address2
		, @City
		, @State
		, @Zip
		, @Phone
		, @Active
		)
	;

	SELECT SCOPE_IDENTITY() AS MemberID;

END;