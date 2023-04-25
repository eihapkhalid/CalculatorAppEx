using Bl;
using CalculatorApp.Utlities;
using Domains;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CalculatorApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region dependency injection
            // Create a new instance of the ServiceCollection class
            var services = new ServiceCollection();

            // Register the required services and their implementations
            services.AddScoped<IBusinessLayer<NormalCalModel>, ClsNormalCal>();
            services.AddScoped<IBusinessLayer<SincCalModel>, ClsSincCal>();
            // Build the service provider
            var serviceProvider = services.BuildServiceProvider();
            #endregion

            string sVarSwitch = string.Empty;
            while (sVarSwitch != "e")
            {
                #region instance of UiHelper 
                UiHelper uiHelper = new UiHelper
        (
            serviceProvider.GetService<IBusinessLayer<NormalCalModel>>(),
            serviceProvider.GetService<IBusinessLayer<SincCalModel>>(),
            new NormalCalModel(),
            new SincCalModel()

         );
                #endregion

                #region Calculator Types
                uiHelper.MainOptions();
                sVarSwitch = Console.ReadLine();
                switch (sVarSwitch)
                {
                    case "e":
                        sVarSwitch = "e";
                        break;
                    case "1":
                        Console.Clear();
                        uiHelper.NormalCalOptions();
                        break;
                    case "2":
                        Console.Clear();
                        uiHelper.SinCalOptions();
                        break;
                } 
                #endregion

            }
        }
    }
}