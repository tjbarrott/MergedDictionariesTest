namespace MauiAppNet6;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		var mergedDictionaries = Application.Current.Resources.MergedDictionaries;
		foreach(var dict in mergedDictionaries)
		{
			if (dict.ContainsKey("Primary"))
			{
				Console.WriteLine("Primary was found in dictionary.");
			}

			foreach(var key in dict.Keys)
			{
				bool containsKey = dict.ContainsKey(key);

				if (containsKey)
				{
					Console.WriteLine($"{key} was found in dictionary.");
				}
				else
				{
					Console.WriteLine($"{key} NOT found in dict.");
				}
			}
		}
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

