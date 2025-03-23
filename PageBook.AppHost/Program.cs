var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.PageBook>("pagebook");


builder.Build().Run();
