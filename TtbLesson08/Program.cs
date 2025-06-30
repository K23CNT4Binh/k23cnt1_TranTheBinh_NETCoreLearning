var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ✅ Hiển thị lỗi chi tiết khi chạy trong môi trường Development
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // 👉 dòng bạn cần thêm
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Các middleware khác
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Định nghĩa route mặc định
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=TtbHome}/{action=TtbIndex}/{id?}");

app.Run();
