using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;

namespace ChannelControlApp.Views;

// Пример программного построения экрана — стартовый монитор
public class MonitorView : UserControl
{
    public MonitorView()
    {
        var status = new TextBlock
        {
            Text = "● Каналы не инициализированы",
            Foreground = new SolidColorBrush(Color.FromRgb(240, 170, 80)),
            FontSize = 14,
            HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center
        };

        var title = new TextBlock
        {
            Text = "Панель мониторинга",
            FontSize = 20,
            FontWeight = FontWeight.Bold,
            Foreground = new SolidColorBrush(Colors.White),
            HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center
        };

        var hint = new TextBlock
        {
            Text = "Здесь будет отображаться состояние каналообразующего оборудования:\nопрос датчиков, статус соединений, журнал событий.",
            FontSize = 14,
            Foreground = new SolidColorBrush(Color.FromRgb(157, 180, 206)),
            TextAlignment = Avalonia.Media.TextAlignment.Center,
            Margin = new Thickness(0, 14, 0, 0)
        };

        Content = new StackPanel
        {
            VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
            Spacing = 8,
            Children = { title, status, hint }
        };
    }
}
