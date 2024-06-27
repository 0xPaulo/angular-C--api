using Microsoft.AspNetCore.Builder;
using PrimeiraApi.Routes;

var builder = WebApplication.CreateBuilder(args);

// swagger V
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// swagger ^

// Cors V
builder.Services.AddCors(option => option.AddDefaultPolicy(policy =>
{
    policy.AllowAnyOrigin();
    policy.AllowAnyHeader();
    policy.AllowAnyMethod();
}));
// Cors ^

// inicia V
var app = builder.Build();

// usa o ASPNETCORE_ENVIRONMENT Development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();
app.MapPessoaRotas();

app.Run();

