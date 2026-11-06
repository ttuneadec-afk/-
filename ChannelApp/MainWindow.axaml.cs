using Avalonia.Controls;
using Avalonia.Interactivity;
using ChannelControlApp.Views;

namespace ChannelControlApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    // Переключение на внутренний экран + показ кнопки «назад»
    private void ShowScreen(Control screen)
    {
        Host.Content = screen;
        MenuPanel.IsVisible = false;
        BtnBack.IsVisible = true;
    }

    private void OnBack(object? sender, RoutedEventArgs e)
    {
        Host.Content = null;
        MenuPanel.IsVisible = true;
        BtnBack.IsVisible = false;
    }

    private void OnStart(object? sender, RoutedEventArgs e) => ShowScreen(new MonitorView());
    private void OnChannels(object? sender, RoutedEventArgs e) => ShowScreen(new ChannelsView());
    private void OnSettings(object? sender, RoutedEventArgs e) => ShowScreen(new SettingsView());
    private void OnAbout(object? sender, RoutedEventArgs e) => ShowScreen(new AboutView());
}
