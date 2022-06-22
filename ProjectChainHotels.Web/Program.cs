using Microsoft.EntityFrameworkCore;
using ProjectChainHotels.Lib.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ChainHotelsContext>(
        conn => conn.UseNpgsql(builder.Configuration.GetConnectionString("ProjectChainHotels"))
        .UseSnakeCaseNamingConvention()
    );

/*builder.Services.AddScoped<>();
builder.Services.AddScoped<>();
builder.Services.AddScoped<>();
builder.Services.AddScoped<>();
builder.Services.AddScoped<>();
builder.Services.AddScoped<>();
builder.Services.AddScoped<>();*/

builder.Services.AddControllers()
                .AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
