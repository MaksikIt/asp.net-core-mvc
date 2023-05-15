using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace обучениеwebd
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services) // регистрация модулей и плагинов
        {
            services.AddMvc();
        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); //отоюражение ошибок
            }
            if (env.IsProduction())
            {
                app.Run(async (context) =>
                {
                    await context.Response.WriteAsync("Production");
                });
            }
            app.UseStatusCodePages();//отбражение кода страница например 404, 500 или 200(успешный запрос)
            app.UseStaticFiles();//отображение статических файлов
            app.UseMvcWithDefaultRoute();//если не указываем полный путь который нужно отобразить, то будет отображаться файл по умолчанию(index.html)
        }
    }
}
