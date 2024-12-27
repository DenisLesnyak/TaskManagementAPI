using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TaskController : ControllerBase
{
    private static List<TaskModel> tasks = new List<TaskModel>
    {
        new TaskModel { Id = 1, Title = "Complete project", Status = "In Progress", Deadline = DateTime.Now.AddDays(5) }
    };

    // Метод GET для получения всех задач
    [HttpGet]
    public IEnumerable<TaskModel> Get()
    {
        return tasks;
    }

    // Метод POST для добавления новой задачи
    [HttpPost]
    public IActionResult Post([FromBody] TaskModel task)
    {
        tasks.Add(task);
        return CreatedAtAction(nameof(Get), new { id = task.Id }, task);
    }
}
