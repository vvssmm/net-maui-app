﻿using QlHui.App.Data.Services.ImplService;
using QlHui.App.Data.Services.IService;
using QlHui.App.Data.Utils;
using Radzen;

namespace QlHui.App.Data.Services
{
    internal static class DependencyInjection
    {
        internal static void InjectService(this IServiceCollection service)
        {
            service.AddScoped<DialogService>();
            service.AddScoped<NotificationService>();
            service.AddScoped<ContextMenuService>();
            service.AddScoped<IUtils, QLUtils>();
            service.AddScoped<IQlHuiService, QlHuiService>();
            service.AddScoped<IQlHuiVienService, QlHuiVienService>();
            service.AddScoped<ILsBoHuiService, LsBoHuiService>();
            service.AddScoped<ILsDongHuiService, LsDongHuiService>();
        }
    }
}
