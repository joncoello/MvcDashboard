
CREATE PROCEDURE Absence.AbsenceRequest_Create
	@StartDate	SMALLDATETIME,
	@EndDate	SMALLDATETIME	
AS

INSERT INTO Absence.AbsenceRequest
(
    StartDate,
    EndDate
)
VALUES
(   @StartDate, -- StartDate - smalldatetime
    @EndDate  -- EndDate - smalldatetime
)

