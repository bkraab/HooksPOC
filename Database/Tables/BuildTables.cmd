sqlcmd -i  "VV_InsightLink.sql" -b -U %1 -P %2 -S %3 -d %4

sqlcmd -i  "CdsServiceConfig.sql" -b -U %1 -P %2 -S %3 -d %4
sqlcmd -i  "CdsServicePrefetch.sql" -b -U %1 -P %2 -S %3 -d %4
sqlcmd -i  "Insight.sql" -b -U %1 -P %2 -S %3 -d %4
sqlcmd -i  "InsightLink.sql" -b -U %1 -P %2 -S %3 -d %4

