using System.ServiceProcess;
using Autofac;

namespace Aspenlaub.Net.GitHub.CSharp.DummyService {
    public static class DummyServiceContainerBuilder {
        public static ContainerBuilder UseDummyService(this ContainerBuilder builder) {
            builder.RegisterType<DummyService>().As<ServiceBase>();
            return builder;
        }
    }
}
