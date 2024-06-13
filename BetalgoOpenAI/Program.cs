using OpenAI.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var openAiApiKey = builder.Configuration["OpenAIApiKey"];

if (string.IsNullOrEmpty(openAiApiKey))
{
    throw new ArgumentNullException("OpenAI API key is not configured.");
}
builder.Services.AddOpenAIService(settings => settings.ApiKey = openAiApiKey);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
