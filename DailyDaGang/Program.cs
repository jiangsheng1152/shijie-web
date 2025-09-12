using DailyDaGang.Components;
using DailyDaGang.Core;
using SqlSugar;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var services = builder.Services;
services.AddRazorComponents()
    .AddInteractiveServerComponents();

services.AddAntDesign();

services.AddHttpContextAccessor();
//ע��SqlSugar��AddScoped
services.AddTransient<ISqlSugarClient>(s =>
{
    //Scoped��SqlSugarClient 
    SqlSugarClient sqlSugar = new SqlSugarClient(new ConnectionConfig()
    {
        DbType = SqlSugar.DbType.Sqlite,
        ConnectionString = "DataSource=outline.db",
        IsAutoCloseConnection = true,
        ConfigureExternalServices = new ConfigureExternalServices()
        {
            EntityService = (x, p) => //��������
            {
                //����ų�DTO��
                p.DbColumnName = UtilMethods.ToUnderLine(p.DbColumnName);//�շ�ת�»��߷���
                                                                         //֧��string?��string  
                if (p.IsPrimarykey == false && new NullabilityInfoContext()
                 .Create(x).WriteState is NullabilityState.Nullable)
                {
                    p.IsNullable = true;
                }
            },

            EntityNameService = (x, p) => //�������
            {
                //����ų�DTO��
                if (p.DbTableName.EndsWith("Entity"))
                    p.DbTableName = p.DbTableName.Substring(0, p.DbTableName.Length - 6);
                p.DbTableName = UtilMethods.ToUnderLine(p.DbTableName);//�շ�ת�»��߷���
            }
        }
    },
   db =>
   {
       var types = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.GetCustomAttributes<SugarTable>().Any()).ToArray();
       if(types.Any())
           db.CodeFirst.InitTables(types);

       db.Aop.OnLogExecuting = (sql, pars) =>
       {
           Console.WriteLine($"{DateTime.Now:HH:mm:ss}:{sql}");
       };
   }
   );
    return sqlSugar;
});

services.AddScoped(typeof(BaseRepository<>));

var app = builder.Build();

TaskInfo.Initialize(app.Services);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
