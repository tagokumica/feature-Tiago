using Application.Interface;
using Application.Service;
using Domain.Interface.Repository;
using Domain.Interface.Service;
using Domain.Service;
using Infra.Data.Context;
using Infra.Data.Repository;
using Infra.Data.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static IServiceCollection RegisterServices(IServiceCollection service)
        {

            service.AddScoped<IAddressRepository, AddressRepository>();
            service.AddScoped<IAddressService, AddressService>();
            service.AddScoped<IAddressAppService, AddressAppService>();


            service.AddScoped<ICustomerRepository, CustomerRepository>();
            service.AddScoped<ICustomerService, CustomerService>();
            service.AddScoped<ICustomerAppService, CustomerAppService>();

            service.AddScoped<IPhoneRepository, PhoneRepository>();
            service.AddScoped<IPhoneService, PhoneService>();
            service.AddScoped<IPhoneAppService, PhoneAppService>();


            service.AddScoped<TesteContext>();
            service.AddScoped<IUnitOfWork, UnitOfWork>();



            return service;
        }


    }
}
