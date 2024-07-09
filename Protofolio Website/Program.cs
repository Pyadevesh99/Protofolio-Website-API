using Login_and_Register_API.Database;
using Microsoft.EntityFrameworkCore;
using Protofolio_Website.Database.Implementations;
using Protofolio_Website.Database.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(p => p.AddPolicy("corspolicy", build =>
{
    build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddScoped<IContactMe, ContactMe>();

//Adding sql server
builder.Services.AddDbContext<Db_Context>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Db_ContextConnectString"));
});

var app = builder.Build();




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("corspolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
