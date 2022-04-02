USE [cs6232-g5]
GO
DROP FUNCTION IF EXISTS sfGetAuthorizedAdminLoginInfo;
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER FUNCTION sfGetAuthorizedAdminLoginInfo (
	@username VARCHAR(45)
    , @password VARCHAR(45)
)
RETURNS VARCHAR(150)
AS
BEGIN

DECLARE @info VARCHAR(150)

SET @info = NULL

IF (ISNULL(@username, '') = '')
BEGIN
    RETURN @info
END

IF (ISNULL(@password, '') = '')
BEGIN
   RETURN @info
END

SELECT
@info = (CASE when LIN.password = HASHBYTES('SHA2_256', @password) THEN CAST(LIN.employeeID AS VARCHAR(45)) + '^' + LIN.username + '^' + REG.name ELSE @info END)
FROM login LIN
INNER JOIN (
    SELECT
    EMP.employeeID
    , EMP.fname + ' ' + EMP.lname AS name
    FROM employee EMP
    INNER JOIN admin ADM
        ON EMP.employeeID = ADM.employeeID
    WHERE
    EMP.active = 1
) REG
    ON LIN.employeeID = REG.employeeID
WHERE
LIN.username = @username
AND LIN.password = HASHBYTES('SHA2_256', @password);

RETURN @info
END
GO

--SELECT [dbo].[sfGetAuthorizedAdminLoginInfo] ('Jane', 'test1234')