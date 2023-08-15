using Dapper.Contrib.Extensions;
using System.Runtime.CompilerServices;
using static TasksApi.Data.TarefaContext;


namespace TasksApi.Endpoints
{
    public static class TarefasEndpoints
    {

        public static void MapTarefasEndpoints(this WebApplication app)
        {
            app.MapGet("/", ()=> $"Welcome to Tasks API - {DateTime.Now}");

            app.MapGet("/tasks", async (GetConnection connectionGetter) =>
            {
                using var con = await connectionGetter();
                var tasks = con.GetAll<Task>().ToList();
               


                if(tasks is null)
                    return Results.NotFound();

                return Results.Ok(tasks);
            });
        }
    }
}
