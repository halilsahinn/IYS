#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Persistance;
using Invo.izin.Yönetim.Sistemi.Caching;
using Invo.izin.Yönetim.Sistemi.Identity;
using Invo.izin.Yönetim.Sistemi.WebAPI.Middleware;
using FluentValidation;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.Department;
using Invo.izin.Yönetim.Sistemi.Application.ValidationRules.Department;
using Invo.izin.Yönetim.Sistemi.Application;
#endregion


var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpContextAccessor();

#region CORS

builder.Services.AddCors(p =>p.AddPolicy("corsPolicy",build =>
    {
        build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
    }

));


#endregion


#region Service Registratition
builder.Services.ConfigurePersistenceServices(builder.Configuration);
builder.Services.ConfigureCacheServices(builder.Configuration);
builder.Services.ConfigureIdentityServices(builder.Configuration);
builder.Services.ConfigureApplicationServices();



#endregion

builder.Services.AddTransient<IValidator<AddDepartmentDto>, AddDepartmentDtoValidator>();


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwagger();
 

app.UseMiddleware<ExceptionMiddleware>();

app.UseHttpsRedirection();


 
#region USE CORS
app.UseCors("corsPolicy");
#endregion

app.UseAuthorization();
app.MapControllers();

app.Run();
