using Microsoft.Extensions.Logging;
using Vectron.Extensions.DependencyInjection.Attributes;

namespace Vectron.Extensions.DependencyInjection.BufferedLogging;

/// <summary>
/// A logger that buffers the messages until they can be written to the final logger setup.
/// </summary>
[Ignore]
public interface IBufferedLogger
{
    /// <summary>
    /// Write all items to the given <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/> instance used for logging.</param>
    void WriteItems(ILogger logger);
}
