using CommunityToolkit.Maui.Views;
using Maui.MultipleWindows.App.Services;
using Maui.MultipleWindows.App.ViewModel;

namespace Maui.MultipleWindows.App.View;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage(MainPageViewModel viewModel, PopupService popupService)
    {
        InitializeComponent();
        
        viewModel.SetPopupContainerId(popupService.RegisterPage(this));
        this.BindingContext = viewModel;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        this.ShowPopup(new MyPopup());
    }
}

