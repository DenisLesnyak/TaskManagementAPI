public class TaskModel
{
    public int Id { get; set; } // Уникальный идентификатор задачи, используется для различия задач в базе данных
    public string Title { get; set; } // Название задачи, которое описывает суть задачи
    public string Status { get; set; } // Текущий статус задачи, например, "Новая", "В процессе", "Завершена"
    public DateTime Deadline { get; set; } // Крайний срок выполнения задачи
}
