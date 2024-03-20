using Microsoft.EntityFrameworkCore;
using Shop.BDContext;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

// ������ ����������� �� appsettings.json
string connection = builder.Configuration.GetConnectionString("DefaultConnection");

// ����������� ���������� � ��
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

var app = builder.Build();


app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=News}/{Action=NewsView}/{id?}"
    );

app.Run();
