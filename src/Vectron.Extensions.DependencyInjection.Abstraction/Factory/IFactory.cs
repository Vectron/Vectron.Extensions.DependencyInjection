namespace Vectron.Extensions.DependencyInjection.Factory;

/// <summary>
/// A factory that can be used to resolve implementation of <typeparamref name="T"/>.
/// </summary>
/// <typeparam name="T">The type this factory will create.</typeparam>
public interface IFactory<T>
    where T : class
{
    /// <summary>
    /// Gets the default implementation.
    /// </summary>
    public T Value
    {
        get;
    }

    /// <summary>
    /// Get a <see cref="IEnumerable{T}"/> with all possible type names this factory can create.
    /// </summary>
    /// <returns>A <see cref="IEnumerable{T}"/>.</returns>
    public IEnumerable<string> GetItemNames();

    /// <summary>
    /// Gets a Type instance by name.
    /// </summary>
    /// <param name="name">The type name to instantiate.</param>
    /// <returns>The instance of the type.</returns>
    public T GetValue(string name);
}
