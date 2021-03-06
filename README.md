# RockApi
 
An api for accessing the data stored in the Financial Portal.

![Test Harness](https://github.com/mackenzieweaver/RockApi/blob/main/readme.jpg?raw=true)

[The live api](https://rock-transactions-api.herokuapp.com/index.html)

## Built with

- C#
- ASP.NET Core
- API project template
- PgAdmin Functions
- Npgsql - .NET Access to PostgreSQL
- SQL
- Newtonsoft
- Swagger / Swashbuckle

## How it works

This api project connects to the database of another project ([the financial portal](https://rock-transactions.herokuapp.com/)) by using the connection string found in Heroku. Within the database context class it connects to npgsql, which is a way to work with postgresql in .NET, and uses the functions that were set up in PgAdmin. The functions perform SQL queries on the financial portal's database. Swagger and swashbuckle are a couple of nuget packages that automatically generate a test harness based on the definitions of your controller's actions and models. The UI was customized by adding css and js to target the generated page.
