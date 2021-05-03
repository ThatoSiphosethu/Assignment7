using System;
using Microsoft.Extensions.DependencyInjection;

namespace Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
           
           var serviceProvider = new ServiceCollection()
            .AddSingleton<IFileRepository, FileRepository>()
            .AddSingleton<IContext, Context>()
            .AddSingleton<IMenu, Menu>()
            .BuildServiceProvider();

            var menu = serviceProvider.GetService<IMenu>();

            menu.Process();

            System.Console.WriteLine("\nThanks for using the movie library!");
        }
    }
}
