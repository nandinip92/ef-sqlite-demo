using ZooManagement;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<Zoo>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();



// builder.Services.AddCors(options=>{
//     options.AddPolicy("Allow Frontend",policy=>{
//         policy.WithOrigins("https://localhost:5173");
//     });
// });
// builder.Services.AddCors(options=>{
//     options.AddDefaultPolicy(policy=>{
//         policy.WithOrigins("https://localhost:5173");
//     });
// });
// app.UseCors();
