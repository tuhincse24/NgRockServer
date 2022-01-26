using NgRockServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
app.MapGet("/apple-app-site-association", async (http) => {
    await http.Response.WriteAsJsonAsync(new AppleDeepLink { applinks=new AppLinks { apps=new string[] { },details= new AppDetails[] { new AppDetails { appID = "J52R8YYJBF.ch.selise.sln.fcsk", paths = new string[] { "/login/reset-password-verification/*" } } } } });
});

app.Run();
