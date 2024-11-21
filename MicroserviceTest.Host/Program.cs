using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var catalog = builder.AddProject<MicroserviceTest_Catalog>("Catalog");
var user = builder.AddProject<MicroserviceTest_User>("Users");

builder.AddProject<MicroserviceTest_Gateway>("Gateway")
    .WithExternalHttpEndpoints()
    .WithReference(catalog)
    .WithReference(user);

builder.Build().Run();
