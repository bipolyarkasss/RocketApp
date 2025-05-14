using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace RocketSimulation.Views;

public partial class RocketView : UserControl
{
    public RocketView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}