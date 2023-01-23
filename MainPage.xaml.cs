namespace AppSwitchNullabilitySupportedTest;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

        var @switch = "System.Reflection.NullabilityInfoContext.IsSupported";
        if (!AppContext.TryGetSwitch(@switch, out var isEnabled))
        {
            CounterBtn.Text = $"Switch is not set";
        }
        else
        {
            CounterBtn.Text = $"Switch is set to: {isEnabled}";
        }

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

