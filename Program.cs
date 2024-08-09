using GameStore.API.Dtos;
using GameStore.API.Endpoints;
using System.Data;
using System.Security.Cryptography;
using System.Xml.Linq;


var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGamesEndpoints();

app.Run();
