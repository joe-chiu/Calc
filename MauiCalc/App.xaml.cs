namespace MauiCalc;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);
		window.Width = 300;
		window.Height = 500;
		window.MinimumHeight = 470;
		window.MinimumWidth = 270;

        return window;
    }
}
