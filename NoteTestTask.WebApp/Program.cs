using NoteTestTask.WebApp.Extensions;

var builder = WebApplication.CreateBuilder(args);

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

builder.Services.AddServices(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/error");
}

app.UseRouting();
app.UseStaticFiles();

app.UseEndpoints(cfg => {
    cfg.MapBlazorHub();
    cfg.MapFallbackToPage("/_host");
});

app.Run();
