using FA.JustBlog.Core.Data;
using FA.JustBlog.Core.Infrastructure;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Services.Category;
using FA.JustBlog.Services.Post;
using FA.JustBlog.Services.Tag;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
	options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();


builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<ITagService, TagService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseMigrationsEndPoint();
}
else
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
	name: "Post",
	pattern: "{controller=Post}/{year}/{month}/{title}",
	defaults: new
	{
		controller = "Post",
		action = "Details",
		year = @"\d{4}",
		month = @"\d{2}",
	}
	);
app.MapControllerRoute(
	name: "Category",
	pattern: "{controller=Category}/{name}",
	defaults: new
	{
		controller = "Category",
		action = "Index",
	}
	);
app.MapControllerRoute(
	name: "Tag",
	pattern: "{controller=Tag}/{name}",
	defaults: new
	{
		controller = "Tag",
		action = "Index",
	}
	);

app.MapAreaControllerRoute(
	name: "Admin",
	areaName: "Admin",
	pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
	);

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

//app.MapRazorPages();

app.Run();