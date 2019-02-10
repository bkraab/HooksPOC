
cls

cd .\Tables
call  BuildTables.cmd %1 %2 %3 %4
cd ..\

cd .\FKs
call  BuildFKs.cmd %1 %2 %3 %4
cd ..\

cd .\DataLoad
call  BuildDataLoad.cmd %1 %2 %3 %4
cd ..\

::test