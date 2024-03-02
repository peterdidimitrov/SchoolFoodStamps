using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.Infrastructure.Extensions;
using SchoolFoodStamps.Web.ModelBinders;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationDbContext(builder.Configuration);
builder.Services.AddApplicationIdentity(builder.Configuration);

builder.Services.AddControllersWithViews(options =>
{
    options.ModelBinderProviders.Insert(0, new DecimalModelBinderProvider());
    options.ModelBinderProviders.Insert(1, new DateModelBinderProvider());
});

builder.Services.AddApplicationServices(typeof(IFoodStampService));

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

await app.RunAsync();
