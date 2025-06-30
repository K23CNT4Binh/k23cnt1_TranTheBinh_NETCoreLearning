using Microsoft.EntityFrameworkCore;
using TtbLesson10EF.Models; // Thay đúng namespace của bạn

var builder = WebApplication.CreateBuilder(args);

// Đăng ký DbContext với ConnectionString từ appsettings.json
builder.Services.AddDbContext<TtbLesson10Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TtbConnect")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=TtbHome}/{action=TtbIndex}/{ttbId?}");

app.Run();
