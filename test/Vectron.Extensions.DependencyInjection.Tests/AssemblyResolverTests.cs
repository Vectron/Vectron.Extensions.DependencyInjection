using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Vectron.Extensions.DependencyInjection.Tests;

/// <summary>
/// Test methods for <see cref="AssemblyResolver"/>.
/// </summary>
[TestClass]
public class AssemblyResolverTests
{
    /// <summary>
    /// Test if we get <see cref="ArgumentNullException"/> when we pass <see langword="null"/> to the constructor.
    /// </summary>
    [TestMethod]
    public void ConstructorThrowsArgumentNullException()
    {
        _ = Assert.ThrowsException<ArgumentNullException>(() =>
        {
            using var resolver = new AssemblyResolver(null!);
        });
        _ = Assert.ThrowsException<ArgumentNullException>(() =>
        {
            using var resolver = new AssemblyResolver(Mock.Of<ILogger<AssemblyResolver>>(), null!);
        });
        _ = Assert.ThrowsException<ArgumentNullException>(() =>
        {
            using var resolver = new AssemblyResolver(Mock.Of<ILogger<AssemblyResolver>>(), [], null!);
        });
    }

    /// <summary>
    /// Check if empty search directories are skipped.
    /// </summary>
    [TestMethod]
    public void EmptySearchDirIsSkipped()
    {
        using var assemblyResolver = new AssemblyResolver(Mock.Of<ILogger<AssemblyResolver>>(), [], [string.Empty, null!]);

        var result = Assembly.Load("Vectron.Extensions.DependencyInjection.TestsAssembly");

        Assert.IsNotNull(result);
    }

    /// <summary>
    /// Check if a assembly is resolved properly.
    /// </summary>
    [TestMethod]
    public void TryResolve()
    {
        using var assemblyResolver = new AssemblyResolver();

        var result = Assembly.Load("Vectron.Extensions.DependencyInjection.TestsAssembly");

        Assert.IsNotNull(result);
    }
}
