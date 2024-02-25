namespace Vectron.Extensions.DependencyInjection.Attributes;

/// <summary>
/// Attribute indicating the type should be registered as scoped by automatic dependency scanning.
/// </summary>
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class ScopedAttribute : Attribute
{
}
