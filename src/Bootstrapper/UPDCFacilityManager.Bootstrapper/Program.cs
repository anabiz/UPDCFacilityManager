using UPDCFacilityManager.Modules.Auth.Core;
using UPDCFacilityManager.Modules.Estates.Core;
using UPDCFacilityManager.Modules.Residence.Core;
using UPDCFacilityManager.Shared.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthConfiguration(builder.Configuration);
builder.Services.AddClusterConfiguration();
builder.Services.AddResidentConfiguration();
builder.Services.AddEstateConfiguration();
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddAuthentication();
builder.Services.AddSharedConfiguration();

builder.Services.ConfigureApplicationCookie(option =>
{
    option.LoginPath = new PathString("/Auth/Login");
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Auth}/{action=Login}/{id?}");

app.Run();
