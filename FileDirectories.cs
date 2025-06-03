namespace HowlEngine.AssetManagement;

public class FileDirectories{


    /// <summary>
    /// Gets the primary directory path where assets are stored.
    /// </summary>

    public string AssetsFileDirectory    { get; private set; } = "";
    

    /// <summary>
    /// Gets the directory path where scene config files are located.
    /// </summary>
    
    public string ScenesFileDirectory    { get; private set; } = "";


    /// <summary>
    /// Gets the directory path where image source and config files are located.
    /// </summary>

    public string ImagesFileDirectory    { get; private set; } = "";


    /// <summary>
    /// Gets the directory path where audio files are located.
    /// </summary>

    public string AudioFileDirectory     { get; private set; } = "";
    

    /// <summary>
    /// Gets the directory path where Tiled template files are located.
    /// </summary>
    
    public string TemplatesFileDirectory { get; private set; } = "";


    /// <summary>
    /// Creates a new instance of FileDirectories.
    /// </summary>

    public FileDirectories(){
        AssetsFileDirectory     = Path.Combine(AppContext.BaseDirectory, "Assets");
        ScenesFileDirectory     = Path.Combine(AssetsFileDirectory, "Scenes\\Exports");
        ImagesFileDirectory     = Path.Combine(AssetsFileDirectory, "Images\\Exports");
        AudioFileDirectory      = Path.Combine(AssetsFileDirectory, "Audio\\Desktop");
        TemplatesFileDirectory  = Path.Combine(AssetsFileDirectory, "Templates\\Exports");
    } 
}