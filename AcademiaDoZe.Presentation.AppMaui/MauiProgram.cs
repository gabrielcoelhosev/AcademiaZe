//Gabriel Coelho Severino
using AcademiaDoZe.Presentation.AppMaui.ViewModels;
using AcademiaDoZe.Presentation.AppMaui.Views;
using Microsoft.Extensions.Logging;
using AcademiaDoZe.Presentation.AppMaui.Configuration;
using AcademiaDoZe.Presentation.AppMaui.Helpers;
namespace AcademiaDoZe.Presentation.AppMaui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            // em MauiProgram.CreateMauiApp() chame LocalizationManager.Instance.SetCulture antes de executar builder

            // aplica a cultura salva nas preferências antes de criar a aplicação, controls, etc.
            LocalizationManager.Instance.SetCulture(Preferences.Get("Cultura", "pt-BR"));

            var builder = MauiApp.CreateBuilder();
            builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialIcons");
            });
            // Configurar serviços da aplicação e repositórios
            ConfigurationHelper.ConfigureServices(builder.Services);

            // Registrar LocalizedManager para injeção quando necessário
            builder.Services.AddTransient<LocalizationManager>();

            // Registrar ViewModels

            builder.Services.AddTransient<DashboardListViewModel>();
            builder.Services.AddTransient<LogradouroListViewModel>();
            builder.Services.AddTransient<LogradouroViewModel>();
            builder.Services.AddTransient<ColaboradorListViewModel>();
            builder.Services.AddTransient<ColaboradorViewModel>();
            builder.Services.AddTransient<AlunoListViewModel>();
            builder.Services.AddTransient<AlunoViewModel>();
<<<<<<< HEAD
            builder.Services.AddTransient<MatriculaListViewModel>();
            builder.Services.AddTransient<MatriculaViewModel>();
=======
>>>>>>> df0a73ee51b361b095f201897a83dfe9089cce65
            // Registrar Views
            builder.Services.AddTransient<DashboardListPage>();
            builder.Services.AddTransient<LogradouroListPage>();
            builder.Services.AddTransient<LogradouroPage>();
            builder.Services.AddTransient<ConfigPage>();
            builder.Services.AddTransient<ColaboradorListPage>();
            builder.Services.AddTransient<ColaboradorPage>();
            builder.Services.AddTransient<AlunoListPage>();
            builder.Services.AddTransient<AlunoPage>();
<<<<<<< HEAD
            builder.Services.AddTransient<MatriculaListPage>();
            builder.Services.AddTransient<MatriculaPage>();
=======
>>>>>>> df0a73ee51b361b095f201897a83dfe9089cce65
#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}
//Gabriel Coelho Severino
//repositorio git  https://github.com/LeandroJader/AcademiaZe