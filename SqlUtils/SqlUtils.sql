sp_configure 'show advanced options', 1
go
reconfigure
go
sp_configure 'clr strict security', 0
go
reconfigure
go
sp_configure 'clr enabled', 1
go
reconfigure
go
drop function if exists MATH_ROUND
go
drop assembly if exists SqlUtils
go
create assembly SqlUtils from 'C:\Data\SqlUtils.dll'
go
create function MATH_ROUND(@value as float, @digits as int) returns float external name SqlUtils.UserDefinedFunctions.MATH_ROUND
go

select ROUND(12.345, 2)
select dbo.MATH_ROUND(12.345, 2)

