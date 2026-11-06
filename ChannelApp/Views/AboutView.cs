using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;

namespace ChannelControlApp.Views;

public class AboutView : UserControl
{
    public AboutView()
    {
        Content = new StackPanel
        {
            VerticalAlignment = VerticalAlignment.Center,
            Spacing = 10,
            Children =
            {
                new TextBlock
                {
                    Text = "О системе",
                    FontSize = 20,
                    FontWeight = FontWeight.Bold,
                    Foreground = Brushes.White,
                    HorizontalAlignment = HorizontalAlignment.Center
                },
                new TextBlock
                {
                    Text = "Выпускная квалификационная работа\n«Разработка специального программного обеспечения\nдля технологического управления оборудованием\nканалообразования для мобильных операционных систем»",
                    FontSize = 14,
                    Foreground = new SolidColorBrush(Color.FromRgb(157, 180, 206)),
                    TextAlignment = TextAlignment.Center,
                    LineHeight = 22
                },
                new TextBlock
                {
                    Text = "C# · Avalonia UI · net 8.0",
                    FontSize = 12,
                    Opacity = 0.6,
                    Foreground = Brushes.White,
                    HorizontalAlignment = HorizontalAlignment.Center
                }
            }
        };
    }
}
