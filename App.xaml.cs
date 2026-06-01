namespace Mahjong_Calculator;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        return new Window(new AppShell()) { Title = "Mahjong_Calculator"};
    }
}
