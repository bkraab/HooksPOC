
sqlcmd -i  "CdsServicePrefetch_FK.sql" -b -U %1 -P %2 -S %3 -d %4
sqlcmd -i  "InsightLink_FK.sql" -b -U %1 -P %2 -S %3 -d %4

