using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using Calendar.DbContexts.DbContexts;
using Calendar.Events.Interface.Iservice;
using Calendar.Events.Services;
using Calendar.Auth.Interface.IService;
using Calendar.Auth.Services;
using Calendar.Events.BL;
using Calendar.Events.Interface.IBL;
using Calendar.Auth.Interface.IBL;
using Calendar.Auth.BL;
using Calendar.Repository.Repository.Generic;
using Calendar.Repository.Repository.Events;
using Calendar.Events.Interface.IRepository.IEvents;
using Calendar.Auth.Interface.IRepository;
using Calendar.Auth.Repository;
using Calendar.GlobalExceptionHandler;

var builder = WebApplication.CreateBuilder(args);




// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//builder.Services.AddDbContext<calendarDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("calendarDbConnection")));

builder.Services.AddDbContext<CalendarDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("calendarDbConnection"), sqlServerOptions =>
    {
        sqlServerOptions.EnableRetryOnFailure();
    });
});

//JWT Authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options => {
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});

builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
         {
             new OpenApiSecurityScheme
             {
                 Reference = new OpenApiReference
                 {
                     Type = ReferenceType.SecurityScheme,
                     Id = "Bearer"
                 },
                 Scheme = "oauth2",
                 Name = "Bearer",
                 In = ParameterLocation.Header,
             },
             new List<string>()
         }
    });
});

//Add Api Versioning
builder.Services.AddApiVersioning(options => {
    // Returns all version with depricated versions
    options.ReportApiVersions = true;
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.ApiVersionReader = ApiVersionReader.Combine(
        //Query Strying type
        new QueryStringApiVersionReader("api-version"),
        //Request Heardes Type
        new HeaderApiVersionReader("Accept-Version"),
        //Media Type
        new MediaTypeApiVersionReader("api-version"));
});


//SERVICES
builder.Services.AddScoped<IEventService, EventService>();
builder.Services.AddScoped<ILoginService,LoginService>();
builder.Services.AddScoped<IApplicationService, ApplicationService>();
builder.Services.AddScoped<IUserRoleService, UserRoleService>();


//BL
//builder.Services.AddScoped(typeof(IGenericBL<>),typeof(GenericBL<>));
builder.Services.AddScoped<IEventBL, EventBL>();
builder.Services.AddScoped<ILoginBL, LoginBL>();
builder.Services.AddScoped<IApplicationBL, ApplicationBL>();
builder.Services.AddScoped<IUserRoleBL, UserRoleBL>();


//Repository

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IEventsRepository, EventsRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IApplicationRepository, ApplicationRepository>();
builder.Services.AddScoped<IUserRolesRepository, UserRolesRepository>();
builder.Services.AddScoped<IPasswordEncryptionService, PasswordEncryptionService>();


builder.Services.AddDistributedRedisCache(options =>
{
    options.Configuration = "test.okit.in:8379,password=Pondy78100!";
    options.InstanceName = "Calendar5b538w";
});



var app = builder.Build();

app.UseMiddleware<GlobalExceptionHandler>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
