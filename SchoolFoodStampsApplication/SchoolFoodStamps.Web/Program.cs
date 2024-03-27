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
});

builder.Services.AddApplicationServices(typeof(IFoodStampService));

//builder.Services.AddAuthentication()
//   .AddFacebook(options =>
//   {
//       IConfigurationSection FBAuthNSection =
//       config.GetSection("Authentication:FB");
//       options.ClientId = FBAuthNSection["ClientId"];
//       options.ClientSecret = FBAuthNSection["ClientSecret"];
//   });

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    app.UseDeveloperExceptionPage();
    //app.UseStatusCodePages();
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

app.MapDefaultControllerRoute();
app.MapRazorPages();

using (IServiceScope scope = app.Services.CreateScope())
{
    IServiceProvider services = scope.ServiceProvider;

    // Seed roles if needed
    await InsertRoles.AddRoles(services);
    await AssignRoles.AssignRolesToUsers(services);
}

await app.RunAsync();
