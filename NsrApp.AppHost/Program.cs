var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.NsrApp>("nsrapp");

builder.Build().Run();
