using MCB.Core.Infra.CrossCutting.DependencyInjection.Abstractions.Enums;
using MCB.Core.Infra.CrossCutting.DependencyInjection.Abstractions.Models;
using FluentAssertions;

namespace MCB.Core.Infra.CrossCutting.DependencyInjection.Abstractions.Tests.ModelsTests;

public class RegistrationTest
{
    [Fact]
    public void Registration_Should_Correctly_Initialized()
    {
        // Arrange
        var dependencyInjectionLifecycle = DependencyInjectionLifecycle.Singleton;
        var serviceType = typeof(string);
        var concreteType = typeof(int);

        // Act
        var registration = new Registration(dependencyInjectionLifecycle, serviceType, concreteType);

        // Assert
        registration.DependencyInjectionLifecycle.Should().Be(dependencyInjectionLifecycle);
        registration.ServiceType.Should().Be(serviceType);
        registration.ConcreteType.Should().Be(concreteType);
    }
}
