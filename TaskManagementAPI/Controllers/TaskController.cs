using Microsoft.AspNetCore.Mvc;

// Атрибут указывает, что это контроллер API
[ApiController]
// Устанавливает базовый маршрут для всех методов контроллера (например, "api/Task")
[Route("api/[controller]")]
public class TaskController : ControllerBase
{
    // Статический список задач для хранения данных (вместо базы данных)
    private static List<TaskModel> tasks = new List<TaskModel>
    {
        // Пример задачи, добавленной по умолчанию
        new TaskModel
        {
            Id = 1,
            Title = "Complete project",
            Status = "In Progress",
            Deadline = DateTime.Now.AddDays(5) // Крайний срок через 5 дней
        }
    };

    // HTTP GET метод для получения всех задач
    [HttpGet]
    public IEnumerable<TaskModel> Get()
    {
        // Возвращает список всех задач
        return tasks;
    }

    // HTTP POST метод для добавления новой задачи
    [HttpPost]
    public IActionResult Post([FromBody] TaskModel task)
    {
        // Добавление задачи в список
        tasks.Add(task);
        // Возвращает HTTP-ответ 201 Created с данными о новой задаче
        return CreatedAtAction(nameof(Get), new { id = task.Id }, task);
    }
}
