using Avalonia.Media;

namespace RayCarrot.RCP.Metro;

public struct GenericIcon
{
    public GenericIcon(string iconKey, IBrush iconColor)
    {
        IconKey = iconKey;
        IconColor = iconColor;
    }

    public string IconKey { get; set; }   // Icon name or resource key
    public IBrush IconColor { get; set; } // Avalonia brush
}
