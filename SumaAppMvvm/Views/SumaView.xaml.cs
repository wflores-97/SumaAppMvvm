using SumaAppMvvm.ViewModel;

namespace SumaAppMvvm.Views;

public partial class SumaView : ContentPage
{
	SumaViewModel ViewModel;
	public SumaView()
	{
		InitializeComponent();
		ViewModel = new SumaViewModel();
		BindingContext = ViewModel;
	}
}