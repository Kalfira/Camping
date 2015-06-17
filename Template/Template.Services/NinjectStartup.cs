using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Template.Domain.Models;
using Template.Infrastructure.Persistance.Repositories;

namespace Template.Services
{
    public class NinjectStartup: NinjectModule
    {
        public override void Load()
        {
            Bind<IGenericRepository>().To<GenericRepository>();
        }
    }
}
