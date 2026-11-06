using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;

namespace ChannelControlApp.Views;

public class ChannelsView : UserControl
{
    public ChannelsView()
    {
        Content = new StackPanel
        {
            VerticalAlignment = VerticalAlignment.Center,
            Spacing = 10,
            Children =
            {
                new TextBlock
                {
                    Text = "Каналы",
                    FontSize = 20,
                    FontWeight = FontWeight.Bold,
                    Foreground = Brushes.White,
                    HorizontalAlignment = HorizontalAlignment.Center
                },
                new TextBlock
                {
                    Text = "Список каналообразующего оборудования:\nдобавление, конфигурация, диагностика.",
                    FontSize = 14,
                    Foreground = new SolidColorBrush(Color.FromRgb(157, 180, 206)),
                    TextAlignment = TextAlignment.Center
                }
            }
        };
    }
}
