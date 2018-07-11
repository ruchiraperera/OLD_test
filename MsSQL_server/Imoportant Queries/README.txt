*** insert query runs continuesly 1000 times....

INSERT INTO [dbo].[tbl_student]
           ([studentName]
           ,[studentDescription]
           ,[marks]
           ,[disable])
     VALUES
           (NEWID()
           ,'TestDescription'
           ,(select ROUND(RAND(1000) *1000,0))
           ,0);
GO 1000

------------------------------------------------------------------------------
RANDOM number generated

NEWID() - provide guid

select ROUND(RAND()*1000,0) - generate random number

------------------------------------------------------------------------------


