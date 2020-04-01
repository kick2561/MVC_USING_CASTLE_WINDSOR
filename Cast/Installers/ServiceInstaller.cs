using Cast.Models;
using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cast.Installers
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container,
    Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            container.Register(
                Component
                    .For<StudentDetailsEntities>()
                    .ImplementedBy<StudentDetailsEntities>()
                    .LifestyleTransient());
        }
    }
}