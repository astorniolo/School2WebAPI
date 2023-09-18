
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using School2WebAPI.Data;
using School2WebAPI.Entities;
using School2WebAPI.Models.AcademicArea;
using School2WebAPI.Models.Course;
using School2WebAPI.Models.ProgramContent;
using School2WebAPI.Models.Student;
using School2WebAPI.Models.Teacher;
using School2WebAPI.Models.Course;
using School2WebAPI.Models.ProgramContent;
using School2WebAPI.Models.Student;
using School2WebAPI.Models.Teacher;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyDataContext>(opt => opt.UseInMemoryDatabase("Schooll"));

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

//Mapers Course --------------------------------------------------------------------------------
app.MapPost("/Course/", async (CoursePostDTO coursePostDTO, MyDataContext _db) =>
{

});

app.MapGet("/Course/{id}", async (int id, MyDataContext _db) =>
{

});

app.MapGet("/Courses", async (MyDataContext _db) =>
{

});

app.MapPut("/Course/{id}", async (int id, MyDataContext _db) =>
{

});

app.MapDelete("/Course/{id}", async (int id, MyDataContext _db) =>
{

});

//Mapers AcademicArea--------------------------------------------------------------------------------
app.MapPost("/AcademicArea/", async (AcademicAreaPostDTO academicAreaPostDTO, MyDataContext _db) =>
{

});

app.MapGet("/AcademicArea/{id}", async (int id, MyDataContext _db) =>
{

});

app.MapGet("/AcademicAreas/", async (MyDataContext _db) =>
{

});

app.MapPut("/AcademicArea/{id}", async (int id, MyDataContext _db) =>
{

});

app.MapDelete("/AcademicArea/{id}", async (int id, MyDataContext _db) =>
{

});


//Mapers ProgramContent----------------------------------------------------------
app.MapPost("/ProgramContent/", async (ProgramContentPostDTO programContentPostDTO, MyDataContext _db) =>
{

});

app.MapGet("/ProgramContent/{id}", async (int id, MyDataContext _db) =>
{

});

app.MapGet("/ProgramContents/", async (MyDataContext _db) =>
{

});

app.MapPut("/ProgramContent/{id}", async (int id, MyDataContext _db) =>
{

});

app.MapDelete("/ProgramContent/{id}", async (int id, MyDataContext _db) =>
{

});

//Mapers Student ----------------------------------------------------------------------

app.MapPost("/Student/", async (StudentPostDTO studentPostDTO, MyDataContext _db) =>
{

});

app.MapGet("/Student/{id}", async (int id, MyDataContext _db) =>
{

});

app.MapGet("/Students/", async (MyDataContext _db) =>
{

});

app.MapPut("/Student/{id}", async (int id, MyDataContext _db) =>
{

});

app.MapDelete("/Student/{id}", async (int id, MyDataContext _db) =>
{

});

//Mapers Teacher----------------------------------------------------------------------

app.MapPost("/Teacher/", async (TeacherPostDTO teacherPostDTO, MyDataContext _db) =>
{

});

app.MapGet("/Teacher/{id}", async (int id, MyDataContext _db) =>
{

});

app.MapGet("/Teachers", async (MyDataContext _db) =>
{

});

app.MapPut("/Teacher/{id}", async (int id, MyDataContext _db) =>
{

});

app.MapDelete("/Teacher/{id}", async (int id, MyDataContext _db) =>
{

});





app.Run();

