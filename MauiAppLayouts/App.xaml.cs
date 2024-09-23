namespace MauiAppLayouts;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
		//MainPage = new StackLayoutDemo();
		//MainPage = new AbsoluteLayoutDemo();
		MainPage  = new GridLayoutDemo();
	}
}
