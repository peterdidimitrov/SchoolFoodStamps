using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data;
using SchoolFoodStamps.Data.Roles;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.Infrastructure.Extensions;
using SchoolFoodStamps.Web.Infrastructure.ModelBinders;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationDbContext(builder.Configuration);

builder.Services.AddApplicationIdentity(builder.Configuration);

builder.Services.AddControllersWithViews(options =>
{
    options.ModelBinderProviders.Insert(0, new DecimalModelBinderProvider());
    options.ModelBinderProviders.Insert(1, new DateModelBinderProvider());
    options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
});

builder.Services.AddApplicationServices(typeof(IFoodStampService));

builder.Services.ConfigureApplicationCookie(cfg => 
{ 
    cfg.LoginPath = "/User/Login";
    cfg.AccessDeniedPath = "/Home/Error/401";
});

WebApplication app = builder.Build();
MigrateDatabase(app.Services);  

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error/500");
    app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");
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
            name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );

    endpoints.MapControllerRoute(
               name: "ProtectingUrlRoute",
                      pattern: "{controller}/{action}/{id}/{information}",
                      defaults: new { Controler = "", Action = "" });

    endpoints.MapDefaultControllerRoute();

    endpoints.MapRazorPages();
});

using (IServiceScope scope = app.Services.CreateScope())
{
    IServiceProvider services = scope.ServiceProvider;

    await InsertRoles.AddRoles(services);
    await AssignRoles.AssignRolesToUsers(services);
}

await app.RunAsync();

static void MigrateDatabase(IServiceProvider serviceProvider)
{
    using (var scope = serviceProvider.CreateScope())
    {
        var dbContext = scope.ServiceProvider.GetRequiredService<SchoolFoodStampsDbContext>();

        dbContext.Database.Migrate(); // Apply pending migrations
    }
}
