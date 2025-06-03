using System.Reflection;

namespace HowlEngine.AssetManagement;

public class AssetManager{


    /// <summary>
    /// Gets the FileDirectories that stores all directories to relevant assets.
    /// </summary>

    public FileDirectories FileDirectories { get; private set; }


    /// <summary>
    /// Gets the TypeFactory for runtime construction of types (class, struct, interface, etc.) when dealing with config files.
    /// </summary>
    private TypeFactory _typeFactory;


    /// <summary>
    /// Creates a new AssetManager instance.
    /// </summary>
    /// <param name="assembly">The assembly where this asset manager will pull all available types (class, struct, interface, etc.) from.</param>

    public AssetManager(Assembly assembly){
        FileDirectories = new FileDirectories();
        _typeFactory = new TypeFactory(assembly);
    }


    /// <summary>
    /// Creates a new instance of a Type within the loaded assembly stored by this AsetManager's TypeFactory.
    /// </summary>
    /// <param name="typeName">The specified name of the Type.</param>
    /// <returns></returns>

    public object? CreateInstance(string typeName){
        return _typeFactory.CreateInstance(typeName);
    }

    /// <summary>
    /// Creates a new instance of a Type within the loaded assembly stored by this AsetManager's TypeFactory.
    /// </summary>
    /// <param name="typeName">The specified name of the Type.</param>
    /// <param name="args">The arguments used to pass through into the Types constructor.</param>
    /// <returns></returns>

    public object? CreateInstance(string typeName, object[] args){
        return _typeFactory.CreateInstance(typeName, args);
    }
}