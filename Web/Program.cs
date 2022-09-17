using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OA.Repo;
using Repository;
using Service.Users;
using Service.Users.Interfaces;
using System.Configuration;
using Web.Areas.Admin;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.Configure<RazorViewEngineOptions>(options =>
    {
        options.ViewLocationExpanders.Add(new AdminViewLocationExpander());
    });

// Add Db Context
builder.Services.AddDbContext<ResumeBuilderDbContext>(item => item.UseSqlServer(builder.Configuration.GetConnectionString("resumeBuilderConnection")));

// Add Dependency Register 
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IUserService, UserService>();

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

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
