using Jokenpo.ViewModel;

namespace Jokenpo.Views;

public partial class PlayerView : ContentPage
{
	public PlayerView()
	{
		InitializeComponent();
		BindingContext = new PlayerViewModel();
	}
}