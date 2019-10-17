using System.ServiceProcess;
using Autofac;

namespace Aspenlaub.Net.GitHub.CSharp.DummyService {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static void Main() {
            var container = new ContainerBuilder().UseDummyService().Build();
            var servicesToRun = new[] { container.Resolve<ServiceBase>() };
            ServiceBase.Run(servicesToRun);
        }
    }
}
