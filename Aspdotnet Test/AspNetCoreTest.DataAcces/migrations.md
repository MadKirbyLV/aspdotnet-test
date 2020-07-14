dotnet ef migrations add InitialCreate --project ../AspNetCoreTest.DataAcces
dotnet ef database update --project ../AspNetCoreTest.DataAcces
dotnet ef migrations add AddAddresses --project ../AspNetCoreTest.DataAcces