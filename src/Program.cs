using System.ServiceProcess;

namespace Aspenlaub.Net.GitHub.CSharp.DummyService {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static void Main() {
            var servicesToRun = new ServiceBase[] { new DummyService() };
            ServiceBase.Run(servicesToRun);
        }
    }
}
