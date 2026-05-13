using Microsoft.EntityFrameworkCore;
using QuickClaim.API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add Services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configure CORS for Angular
builder.Services.AddCors(options => {
    options.AddPolicy("AngularPolicy", p =>
        p.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AngularPolicy");
app.UseHttpsRedirection();
app.MapControllers();

app.Run();