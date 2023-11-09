using FieldEdgeBackend.Interfaces;
using FieldEdgeBackend.Repository;
using FieldEdgeBackend.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped< ICustomerService, CustomerService > ();

//configure httpclient service
builder.Services.AddHttpClient("FieldEdgeWebDeveloper", client =>
{
    //customize as per your need
    client.BaseAddress = new Uri("https://getinvoices.azurewebsites.net/api/");
    //client.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
    //client.DefaultRequestHeaders.Add("User-Agent", "HttpClientFactoryExample");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
           .AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
