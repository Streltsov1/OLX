using Microsoft.EntityFrameworkCore;
using System.Reflection;
using FluentValidation.AspNetCore;
using DataAccess.Data;
using BusinessLogic.Mapping;
using BusinessLogic;
using DataAccess;
using BusinessLogic.Services;
using OLX.Helpers;
using Microsoft.AspNetCore.Identity;
using DataAccess.Data.Entities;
using BusinessLogic.Interfaces;
using OLX.Services;

var builder = WebApplication.CreateBuilder(args);

var connStr = builder.Configuration.GetConnectionString("LocalDb");
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<OLXDbContext>(opts =>
                opts.UseSqlServer(connStr));

builder.Services.AddAutoMapper();
builder.Services.AddFluentValidator();

builder.Services.AddCustomServices();
builder.Services.AddFavoriteService();
builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromDays(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
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

app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
