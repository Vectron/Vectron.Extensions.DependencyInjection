using Vectron.Extensions.DependencyInjection.Attributes;

namespace Vectron.Extensions.DependencyInjection.TestsAssembly;

/// <summary>
/// A <see cref="IAttributeClass"/> with  <see cref="ScopedAttribute"/> attached.
/// </summary>
[Scoped]
public class ScopedClass : IAttributeClass
{
}
