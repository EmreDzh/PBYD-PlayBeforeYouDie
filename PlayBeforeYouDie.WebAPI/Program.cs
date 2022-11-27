var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplicationServices();
builder.Services.AddHouseRentingDbContext(builder.Configuration);

var app = builder.Build();

builder.Services.AddCors(options =>
{
    options.AddPolicy("all", opt =>
    {
        opt.AllowAnyOrigin();
        opt.AllowAnyMethod();
    });
});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
