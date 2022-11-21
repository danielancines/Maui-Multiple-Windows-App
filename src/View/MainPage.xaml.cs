using Maui.MultipleWindows.App.Services;
using Maui.MultipleWindows.App.ViewModel;

namespace Maui.MultipleWindows.App.View;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel viewModel, PopupService popupService)
    {
        InitializeComponent();
        viewModel.SetPopupContainerId(popupService.RegisterPage(this));
        this.BindingContext = viewModel;
    }
}

