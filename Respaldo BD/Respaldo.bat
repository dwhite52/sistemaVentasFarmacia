echo off 
if not exist C:\BDmysql   Md C:\BDmysql
cd C:\Program Files\MySQL\MySQL Server 5.7\bin
mysqldump --user=root --password=1234 --databases Sist_Ventas> "C:\BDmysql\RespaldoBD.sql"