sql cursor 


Row lock in SQL Server table 

BEGIN TRAN SELECT * FROM tablename WITH (HOLDLOCK, ROWLOCK)
WHERE ID = 1

nolock

PAGE Level Locks in SQL Server

WITH (NOLOCK)
WITH (READPAST)
WITH (TABLOCK)
WITH (TABLOCKX, HOLDLOCK)
WITH (HOLDLOCK)


sp_WhoIsActive

SELECT dest.TEXT AS [Query],
deqs.execution_count [Count],
deqs.last_execution_time AS [Time]
FROM sys.dm_exec_query_stats AS deqs
CROSS APPLY sys.dm_exec_sql_text(deqs.sql_handle) AS dest
ORDER BY deqs.last_execution_time DESC

//---------------------------------------------------------------------------------------

When inserting a record into this table, does it lock the whole table?

Not by default, but if you use the TABLOCK hint or if you're doing certain kinds of bulk load operations, then yes.