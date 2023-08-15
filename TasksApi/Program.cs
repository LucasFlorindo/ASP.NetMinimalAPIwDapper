using TasksApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.AddPersistence();


var app = builder.Build();

//app.maptarefasextensions();


app.Run();
