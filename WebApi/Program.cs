using Microsoft.EntityFrameworkCore;
using Web.Application.AccontServices;
using Web.Application.Interfaces;
using Web.Dommain.Interfaces;
using Web.Dommain.Services;
using Web.Infrainstructure.Repository.Data;


var builder = WebApplication.CreateBuilder(args);

//Data base

builder.Services.AddDbContext<Web.Infrainstructure.Data.AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefatulConnection")));

//Serviços de Inejção de dependencia

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddScoped<IAccountServicesDommain, AccountServicesDommain>();
builder.Services.AddScoped<IAccountPlanServices, AccountPlanServices>();
builder.Services.AddScoped<IAccountPlanRepositoy, AccountPlanRepository>();

builder.Services.AddControllers();
var app = builder.Build();



// Configure the HTTP request pipeline.a

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
