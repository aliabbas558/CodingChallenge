using Microsoft.EntityFrameworkCore;
using Quotable.ApiClient;
using Quotable.Business;
using Shippment.Business;
using Shippment.Persistence.Context;
using Shippment.Persistence.Repository;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddSingleton<IQuoteService, QuoteService>();

builder.Services.AddSingleton<IQuoteClient, QuoteClient>();

builder.Services.AddHttpClient<IQuoteClient, QuoteClient>(client =>
{
    client.BaseAddress = new Uri("https://api.quotable.io/");
});

builder.Services.AddScoped<IShippmentService, ShippmentService>();
builder.Services.AddScoped<IShippmentRepository, ShippmentRepository>();
builder.Services.AddDbContext<IShippmentDatabaseContext, ShippmentDatabaseContext>();

string connString = builder.Configuration.GetConnectionString("ShippmentDatabase");
builder.Services.AddDbContext<ShippmentDatabaseContext>(options =>
 options.UseSqlServer(connString)
);


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


