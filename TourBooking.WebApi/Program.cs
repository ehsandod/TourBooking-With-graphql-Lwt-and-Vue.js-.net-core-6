using GraphQL.Server.Ui.Voyager;
using Microsoft.Extensions.Options;
using TourBooking.Application.Commen.Entities;
using TourBooking.Application.Services;
using TourBooking.Infrastructure.Repositories;
using TourBooking.WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.ConfigureServices();
builder.Services.AddOurAuthentication(builder.Configuration.GetSection("jwt").Get<AppSettings>());
builder.Services.AddSwaggerGen();


var app = builder.Build();

//app.UseMvc();
app.UseAuthentication();
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapGraphQL();
app.UseGraphQLVoyager(new VoyagerOptions() { GraphQLEndPoint = "/graphql" }, "/graphql-voyager");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.UseSwagger();
app.UseSwaggerUI(c => {
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V2");
});

app.Run();
