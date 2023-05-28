using CleverAppen.ViewModels;
using Firebase.Storage;

namespace CleverAppen.Views;

public partial class TakePicture : ContentPage
{
	public TakePicture()
	{
        BindingContext = new PhotoViewModel();
		InitializeComponent();
	}
}