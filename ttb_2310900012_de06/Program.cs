using Microsoft.EntityFrameworkCore;
using ttb_2310900012_de06.Models; // 👈 Đảm bảo đúng namespace chứa DbContext

var builder = WebApplication.CreateBuilder(args);

// 1. ✅ Đăng ký DbContext vào DI container
builder.Services.AddDbContext<TtbDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TtbConnect"))); // 👈 Đảm bảo bạn đã cấu hình chuỗi TtbConnect trong appsettings.json

// 2. ✅ Đăng ký MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 3. ✅ Cấu hình pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();    // Chuyển sang HTTPS
app.UseStaticFiles();         // Dùng wwwroot

app.UseRouting();
app.UseAuthorization();

// 4. ✅ Định tuyến mặc định
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=TtbHome}/{action=TtbIndex}/{id?}");

app.Run();
