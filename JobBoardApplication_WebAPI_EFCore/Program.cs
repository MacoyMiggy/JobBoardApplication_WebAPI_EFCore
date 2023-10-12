using JobBoardApplication_WebAPI_EFCore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<JobBoardAppWebApiContext>(options
    => options.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=JobBoardApp_WebAPI;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
);


var app = builder.Build();

//using (var scope = app.Services.CreateScope())
//{
//    var service = scope.ServiceProvider;
//    var context = service.GetService<JobBoardAppWebApiContext>();
//}




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
