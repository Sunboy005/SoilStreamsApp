using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using SOILSTREAMAPI.Data;
using SOILSTREAMAPI.Services.Implementations;
using SOILSTREAMAPI.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers()
                .ConfigureApiBehaviorOptions(opt => opt.SuppressModelStateInvalidFilter = true)
                .AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling =
                     Newtonsoft.Json.ReferenceLoopHandling.Ignore).AddNewtonsoftJson(x =>
                     x.SerializerSettings.ContractResolver = new DefaultContractResolver());
builder.Services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling =
    Newtonsoft.Json.ReferenceLoopHandling.Ignore).AddNewtonsoftJson(x =>
    x.SerializerSettings.ContractResolver = new DefaultContractResolver());
builder.Services.AddDbContextPool<SoilStreamsDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddScoped<IProductServices, ProductServices>();
builder.Services.AddScoped<IStoreProductServices, StoreProductServices>();
builder.Services.AddScoped<IAuthServices, AuthServices>();
builder.Services.AddScoped<IOrderServices, OrderServices>();

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
