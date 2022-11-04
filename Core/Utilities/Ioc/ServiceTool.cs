using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Ioc
{
    public class ServiceTool
    {
        //Biz Kendi IOC conteinerımızı businesste kumuştuk ama o bizim oluşturduğumuz interfaceler olduğu için orda kendi injection'larımızı yapmıştık
        // IHttAccessoer bizim oluşturmadığımız bir interface olmadığı için onun injectionunu kendimiz serviceTool sayedinde yapmaktayız
        // IHttpAccessor bir requestin başından sonuna kadar takibini yapıyor
        public static IServiceProvider ServiceProvider { get; private set; }
        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}
