using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PBYD___PlayBeforeYouDie.ModelBinders;
using PlayBeforeYouDie.Infrastructure.Data;
using PlayBeforeYouDie.Infrastructure.Data.Models.Users;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
    {
        options.SignIn.RequireConfirmedPhoneNumber = false;
        options.SignIn.RequireConfirmedEmail = false;
        options.Password.RequiredLength = builder.Configuration.GetValue<int>("Identity:RequiredLength");
        options.Password.RequireNonAlphanumeric = builder.Configuration.GetValue<bool>("Identity:RequireNonAlphanumeric");
    })
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/User/Login";
});

builder.Services.AddControllersWithViews()
    .AddMvcOptions(options =>
    {
        options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
        options.ModelBinderProviders.Insert(0, new DecimalModelBinderProvider());
    });



builder.Services.AddApplicationServices();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("MyPolicy", policy =>
    {
        policy.RequireAuthenticatedUser();
        policy.RequireRole("GameMaster");
        policy.RequireRole("Administrator");
    });
});

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
        );

    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

    endpoints.MapRazorPages();
});

app.MapRazorPages();

app.Run();
