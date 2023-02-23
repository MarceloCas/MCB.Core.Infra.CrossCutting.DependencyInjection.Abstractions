using MCB.Core.Infra.CrossCutting.DependencyInjection.Abstractions.Enums;

namespace MCB.Core.Infra.CrossCutting.DependencyInjection.Abstractions.Models;

public readonly record struct Registration
{
    // Properties
    public DependencyInjectionLifecycle DependencyInjectionLifecycle { get; }
    public Type? ServiceType { get; }
    public Type? ConcreteType { get; }

    // Constructors
    public Registration(
        DependencyInjectionLifecycle dependencyInjectionLifecycle,
        Type? serviceType,
        Type? concreteType
    )
    {
        DependencyInjectionLifecycle = dependencyInjectionLifecycle;
        ServiceType = serviceType;
        ConcreteType = concreteType;
    }
}
