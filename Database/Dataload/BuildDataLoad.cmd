
sqlcmd -i  "VV_InsightLink_Data.sql" -b -U %1 -P %2 -S %3 -d %4

sqlcmd -i  "CdsServiceConfig_data.sql" -b -U %1 -P %2 -S %3 -d %4
sqlcmd -i  "CdsServicePrefetch_Data.sql" -b -U %1 -P %2 -S %3 -d %4
sqlcmd -i  "Insights_Data.sql" -b -U %1 -P %2 -S %3 -d %4
