# ExcelWebTool

#Open the Developer PowerShell
Tool -> Command Line -> Developer PowerShell

#Run the code bellow
#Restore nuget
dotnet restore
#move to this folder
cd ExcelWebTool.Repositories
#add migrations
dotnet ef --startup-project ../ExcelWebTool.web/ migrations add New-migration-Name
#update db
dotnet ef --startup-project ../ExcelWebTool.web/ database update

