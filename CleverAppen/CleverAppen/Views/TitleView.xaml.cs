namespace CleverAppen.Views;

public partial class TitleView : ContentView
{
	public TitleView()
	{
		InitializeComponent();
	}

    private async void AccountImageButtons_Clicked(object sender, EventArgs e)
    {
        //await Shell.Current.GoToAsync(nameof(AccountOptionsPage));
    }
    private async void AddPictureImageButton_Clicked(object sender, EventArgs e)
    {
        //await Shell.Current.GoToAsync(nameof(AddInvoicePage));
    }
}