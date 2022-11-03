using MCB.Core.Infra.CrossCutting.DependencyInjection.Abstractions.Enums;
using MCB.Core.Infra.CrossCutting.DependencyInjection.Abstractions.Models;

namespace MCB.Core.Infra.CrossCutting.DependencyInjection.Abstractions.Interfaces;

public interface IDependencyInjectionContainer
{
    #region [ Scopes ]
    void CreateNewScope();
    #endregion

    #region [ Resolve ]
    object? Resolve(Type type);
    TType? Resolve<TType>();
    #endregion

    #region [ Register ]
    void Register(DependencyInjectionLifecycle lifecycle, Type serviceType);
    void Register(DependencyInjectionLifecycle lifecycle, Type serviceType, Func<IDependencyInjectionContainer, object?> serviceTypeFactory);
    void Register(DependencyInjectionLifecycle lifecycle, Type serviceType, Type concreteType);
    void Register(DependencyInjectionLifecycle lifecycle, Type serviceType, Type concreteType, Func<IDependencyInjectionContainer, object?> concreteTypeFactory);

    void Register<TServiceType>(DependencyInjectionLifecycle lifecycle);
    void Register<TServiceType>(DependencyInjectionLifecycle lifecycle, Func<IDependencyInjectionContainer, TServiceType?> serviceTypeFactory);
    void Register<TServiceType, TConcreteType>(DependencyInjectionLifecycle lifecycle);
    void Register<TServiceType, TConcreteType>(DependencyInjectionLifecycle lifecycle, Func<IDependencyInjectionContainer, TConcreteType?> concreteTypeFactory);

    void RegisterTransient<TServiceType>();
    void RegisterTransient<TServiceType>(Func<IDependencyInjectionContainer, TServiceType?> serviceTypeFactory);
    void RegisterTransient<TServiceType, TConcreteType>();
    void RegisterTransient<TServiceType, TConcreteType>(Func<IDependencyInjectionContainer, TConcreteType?> concreteTypeFactory);

    void RegisterScoped<TServiceType>();
    void RegisterScoped<TServiceType>(Func<IDependencyInjectionContainer, TServiceType?> serviceTypeFactory);
    void RegisterScoped<TServiceType, TConcreteType>();
    void RegisterScoped<TServiceType, TConcreteType>(Func<IDependencyInjectionContainer, TConcreteType?> concreteTypeFactory);

    void RegisterSingleton<TServiceType>();
    void RegisterSingleton<TServiceType>(Func<IDependencyInjectionContainer, TServiceType?> serviceTypeFactory);
    void RegisterSingleton<TServiceType, TConcreteType>();
    void RegisterSingleton<TServiceType, TConcreteType>(Func<IDependencyInjectionContainer, TConcreteType?> concreteTypeFactory);
    #endregion

    #region [ Unregister ]
    void Unregister(Type serviceType);
    void Unregister<TService>();
    #endregion

    IEnumerable<Registration> GetRegistrationCollection();
}
