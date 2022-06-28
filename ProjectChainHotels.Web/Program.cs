using Microsoft.EntityFrameworkCore;
using ProjectChainHotels.Lib.Data;
using ProjectChainHotels.Lib.Data.Repositories;
using ProjectChainHotels.Lib.Data.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ChainHotelsContext>(
        conn => conn.UseNpgsql(builder.Configuration.GetConnectionString("ProjectChainHotels"))
        .UseSnakeCaseNamingConvention()
    );

builder.Services.AddScoped<IHotelRepository, HotelRepository>();
builder.Services.AddScoped<IHotelGuestRepository, HotelGuestRepository>();
builder.Services.AddScoped<IBedroomRepository, BedroomRepository>();
builder.Services.AddScoped<IBedroomDescriptionRepository, BedroomDescriptionRepository>();
builder.Services.AddScoped<IReserveRepository, ReserveRepository>();
builder.Services.AddScoped<IReserveXHotelGuestRepository, ReserveXHotelGuestRepository>();
/*builder.Services.AddScoped<IServiceXHotelRepository, ServiceRepository>();*/
builder.Services.AddScoped<IServiceXHotelRepository, ServiceXHotelRepository>();

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
