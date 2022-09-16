using GraphQL.Server.Ui.Voyager;
using TourBooking.WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.ConfigureServices();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapGraphQL();
app.UseGraphQLVoyager(new VoyagerOptions() { GraphQLEndPoint = "/graphql" }, "/graphql-voyager");

app.Run();