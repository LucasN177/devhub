namespace Syncro.Services;

public class AppStateService
{
    public bool IsDarkMode { get; private set; }

    public bool IsDrawerOpen { get; private set; } = true;
    
    public event Action? OnChange;

    public void ToggleDarkMode()
    {
        IsDarkMode = !IsDarkMode;
        NotifyStateChanged();
    }

    public void SetDarkMode(bool isDarkMode)
    {
        if (IsDarkMode == isDarkMode) return;
        IsDarkMode = isDarkMode;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
    
    public void DrawerToggle()
    {
        IsDrawerOpen = !IsDrawerOpen;
        NotifyStateChanged();
    }

    public void SetDrawerOpen(bool isOpen)
    {
        IsDrawerOpen = isOpen;
        NotifyStateChanged();
    }
}
