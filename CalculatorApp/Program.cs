using Bl;
using CalculatorApp.Utlities;
using Domains;
using Microsoft.Extensions.DependencyInjection;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args, NormalCalModel model, SincCalModel sincmodel)
        {
            // Create a new instance of the ServiceCollection class
            var services = new ServiceCollection();

            // Register the required services and their implementations
            services.AddScoped<IBusinessLayer<NormalCalModel>, ClsNormalCal>();
            services.AddScoped<IBusinessLayer<SincCalModel>, ClsSincCalBl>();
            // Build the service provider
            var serviceProvider = services.BuildServiceProvider();

            string sVarSwitch = string.Empty;
            while (sVarSwitch != "e")
            {
                UiHelper uiHelper = new UiHelper
                (
                    serviceProvider.GetService<IBusinessLayer<NormalCalModel>>(),
                    serviceProvider.GetService<IBusinessLayer<SincCalModel>>()
                 );

                uiHelper.MainOptions();
                sVarSwitch = Console.ReadLine();
                switch (sVarSwitch)
                {
                    case "e":
                        sVarSwitch = "e";
                        break;
                    case "1":
                        Console.Clear();
                        uiHelper.NormalCalOptions(model);
                        break;
                    case "2":
                        Console.Clear();
                        uiHelper.SinCalOptions(sincmodel);
                        break;
                    case "3":
                        break;
                }

            }
        }
    }
}