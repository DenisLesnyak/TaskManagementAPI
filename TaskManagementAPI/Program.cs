var builder = WebApplication.CreateBuilder(args);

// Инициализация билдера приложения
// Добавление сервисов в контейнер зависимостей
builder.Services.AddControllers(); // Добавление поддержки контроллеров (для обработки HTTP-запросов)

// Подключение Swagger для документирования и тестирования API
builder.Services.AddEndpointsApiExplorer(); // Поддержка для минимальных API
builder.Services.AddSwaggerGen(); // Генерация документации API с помощью Swagger
builder.Services.AddRazorPages(); // Добавление поддержки Razor Pages (опционально, если у тебя есть фронтенд-страницы)

// Создание приложения
var app = builder.Build();

// Настройка middleware (промежуточного ПО)
// Включение Swagger и интерфейса Swagger UI в режиме разработки
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Включение генерации Swagger-документации
    app.UseSwaggerUI(); // Включение пользовательского интерфейса Swagger UI
}

app.UseHttpsRedirection(); // Принудительное использование HTTPS
app.UseAuthorization(); // Подключение механизма авторизации

// Маршрутизация запросов к контроллерам
app.MapControllers(); // Обработка маршрутов для контроллеров
app.MapRazorPages(); // Обработка маршрутов для Razor Pages (если они используются)

// Запуск приложения
app.Run();
