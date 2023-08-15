using System.ComponentModel.DataAnnotations.Schema;

namespace TasksApi.Data
{
        [Table("Tasks")]

         public record Task(int Id, string Activity, string Status);
  

    
}
