using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;

namespace ChannelControlApp.Views;

public class SettingsView : UserControl
{
    public SettingsView()
    {
        // Две демонстрационные настройки: период опроса и язык интерфейса
        var period = new ComboBox
        {
            Width = 200,
            SelectedIndex = 0,
            ItemsSource = new[] { "1 секунда", "5 секунд", "30 секунд", "1 минута" }
        };

        Content = new StackPanel
        {
            VerticalAlignment = VerticalAlignment.Center,
            Spacing = 16,
            Children =
            {
                new TextBlock
                {
                    Text = "Настройки",
                    FontSize = 20,
                    FontWeight = FontWeight.Bold,
                    Foreground = Brushes.White,
                    HorizontalAlignment = HorizontalAlignment.Center
                },
                new StackPanel
                {
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Spacing = 6,
                    Children =
                    {
                        new TextBlock { Text = "Период опроса каналов:", Foreground = Brushes.White, FontSize = 14 },
                        period
                    }
                },
                new ToggleSwitch { Content = "Ведение журнала событий", IsChecked = true }
            }
        };
    }
}
