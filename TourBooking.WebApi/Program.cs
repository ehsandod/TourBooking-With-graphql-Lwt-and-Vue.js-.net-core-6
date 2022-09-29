using GraphQL.Server.Ui.Voyager;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TourBooking.Application.Commen.Entities;
using TourBooking.Application.Services;
using TourBooking.Infrastructure.DBContext;
using TourBooking.Infrastructure.Repositories;
using TourBooking.WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.ConfigureServices();
builder.Services.AddOurAuthentication(builder.Configuration.GetSection("jwt").Get<AppSettings>());
builder.Services.AddSwaggerGen();
builder.Services.AddDistributedRedisCache(option =>
{
    option.Configuration = "localhost";
    option.InstanceName = "mydb_";
});

builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
});


var app = builder.Build();
//using (var scope = app.Services.CreateScope())
//{
//    var db = scope.ServiceProvider.GetRequiredService<ApplicationDBContext>();
//    db.Database.Migrate();
//}

app.UseCors(options =>  options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapGraphQL();
app.UseGraphQLVoyager(new VoyagerOptions() { GraphQLEndPoint = "/graphql" }, "/graphql-voyager");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V2");
});

app.Run();
