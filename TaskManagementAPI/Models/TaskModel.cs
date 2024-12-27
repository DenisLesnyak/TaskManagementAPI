public class TaskModel
{
    public int Id { get; set; } // Уникальный идентификатор задачи
    public string Title { get; set; } // Название задачи
    public string Status { get; set; } // Статус задачи (например, "В процессе", "Завершена")
    public DateTime Deadline { get; set; } // Крайний срок
}
