﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System.Reflection;
using System.IO;
using System;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Todo.Database.Models;
using Todo.Database.Resources;
using Todo.Domain.Extensions;
using Todo.Domain.Models.User;


namespace Todo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper();
            services.AddEntityFrameworkNpgsql().AddDbContext<DatabaseContext>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly("Todo.API")));
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<DatabaseContext>();
            services.AddDomain();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                    {Title = "Todo.API", Version = "v1"});

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Todo.API V1");
                    c.RoutePrefix = String.Empty;
                });
                app.UseDefaultFiles();
                app.UseStaticFiles();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id}");
            });
        }
    }
}

/// ПОЧИТАТЬ:
/// методы HTTP
/// Принципы ООП
/// Отличия классов и структур
/// Async/await назначение, что такое Task в net core
/// Зачем нужен класс Startup.cs, его методы
/// Зачем нужен класс Program.cs
/// Middleware
/// Controller, View, Model
///
///
/// ПОДЕЛАТЬ:
/// Fluent Api
/// Регистрация, удаление, редактирование, получение данных пользователя (UserController) 4 метода
/// Авторизация (AccountController): Login, Logout (Identity)
/// Задачи привязать к пользователям