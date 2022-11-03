using MCB.Core.Infra.CrossCutting.DependencyInjection.Abstractions.Enums;

namespace MCB.Core.Infra.CrossCutting.DependencyInjection.Abstractions.Models;

public record Registration
{
    // Properties
    public DependencyInjectionLifecycle DependencyInjectionLifecycle { get; }
    public Type? AbstractionType { get; }
    public Type? ConcreteType { get; }

    // Constructors
    public Registration(
        DependencyInjectionLifecycle dependencyInjectionLifecycle,
        Type? abstractionType,
        Type? concreteType
    )
    {
        DependencyInjectionLifecycle = dependencyInjectionLifecycle;
        AbstractionType = abstractionType;
        ConcreteType = concreteType;
    }

}
