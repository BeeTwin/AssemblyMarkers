using System.Reflection;

namespace AssemblyMarkers;

/// <summary>
/// Serves as a base class for creating custom assembly markers.
/// This class provides static properties to access the type and assembly of the derived marker class.
/// </summary>
/// <example>
/// Example usage of a custom assembly marker:
/// <code>
/// // Define a custom assembly marker:
/// public abstract class MyAssemblyMarker : AssemblyMarker&lt;MyAssemblyMarker&gt;;
/// 
/// // Use in reflection:
/// Type type = MyAssemblyMarker.Type;
/// Assembly assembly = MyAssemblyMarker.Assembly;
/// </code>
/// </example>
/// <typeparam name="TAssemblyMarker">The specific type of the assembly marker.</typeparam>
public abstract class AssemblyMarker<TAssemblyMarker>
    where TAssemblyMarker : AssemblyMarker<TAssemblyMarker>
{
    /// <summary>
    /// Gets the type of the assembly marker.
    /// </summary>
    public static readonly Type Type = typeof(TAssemblyMarker);
    
    /// <summary>
    /// Gets the assembly containing the assembly marker.
    /// </summary>
    public static readonly Assembly Assembly = Type.Assembly;
}

