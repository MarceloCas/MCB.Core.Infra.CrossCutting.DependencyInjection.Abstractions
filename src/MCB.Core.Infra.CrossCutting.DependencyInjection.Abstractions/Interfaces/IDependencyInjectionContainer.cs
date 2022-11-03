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
    void Register(DependencyInjectionLifecycle lifecycle, Type concreteType);
    void Register(DependencyInjectionLifecycle lifecycle, Type concreteType, Func<IDependencyInjectionContainer, object?> concreteTypeFactory);
    void Register(DependencyInjectionLifecycle lifecycle, Type abstractionType, Type concreteType);
    void Register(DependencyInjectionLifecycle lifecycle, Type abstractionType, Type concreteType, Func<IDependencyInjectionContainer, object?> concreteTypeFactory);

    void Register<TConcreteType>(DependencyInjectionLifecycle lifecycle);
    void Register<TConcreteType>(DependencyInjectionLifecycle lifecycle, Func<IDependencyInjectionContainer, TConcreteType?> concreteTypeFactory);
    void Register<TAbstractionType, TConcreteType>(DependencyInjectionLifecycle lifecycle);
    void Register<TAbstractionType, TConcreteType>(DependencyInjectionLifecycle lifecycle, Func<IDependencyInjectionContainer, TConcreteType?> concreteTypeFactory);

    void RegisterTransient<TConcreteType>();
    void RegisterTransient<TConcreteType>(Func<IDependencyInjectionContainer, TConcreteType?> concreteTypeFactory);
    void RegisterTransient<TAbstractionType, TConcreteType>();
    void RegisterTransient<TAbstractionType, TConcreteType>(Func<IDependencyInjectionContainer, TConcreteType?> concreteTypeFactory);

    void RegisterScoped<TConcreteType>();
    void RegisterScoped<TConcreteType>(Func<IDependencyInjectionContainer, TConcreteType?> concreteTypeFactory);
    void RegisterScoped<TAbstractionType, TConcreteType>();
    void RegisterScoped<TAbstractionType, TConcreteType>(Func<IDependencyInjectionContainer, TConcreteType?> concreteTypeFactory);

    void RegisterSingleton<TConcreteType>();
    void RegisterSingleton<TConcreteType>(Func<IDependencyInjectionContainer, TConcreteType?> concreteTypeFactory);
    void RegisterSingleton<TAbstractionType, TConcreteType>();
    void RegisterSingleton<TAbstractionType, TConcreteType>(Func<IDependencyInjectionContainer, TConcreteType?> concreteTypeFactory);
    #endregion

    #region [ Unregister ]
    void Unregister(Type concreteType);
    void Unregister<T>();
    #endregion

    IEnumerable<Registration> GetRegistrationCollection();
}
