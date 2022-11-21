using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Maui.MultipleWindows.App.Services;
using Maui.MultipleWindows.App.View;

namespace Maui.MultipleWindows.App.ViewModel;

public partial class MainPageViewModel : ObservableObject
{
    private IServiceProvider _serviceProvider;
    private PopupService _popupService;
    private Guid _popupContainerId;

    public MainPageViewModel(IServiceProvider serviceProvider, PopupService popupService)
    {
        this._serviceProvider = serviceProvider;
        this._popupService = popupService;

        this.NewWindowButtonText = "Open New Window";
        this.ShowPopupButtonText = "Show Popup";
    }

    [ObservableProperty]
    private string newWindowButtonText;
    [ObservableProperty]
    private string showPopupButtonText;

    [RelayCommand]
    private void NewWindow()
    {
        var newPage = this._serviceProvider.GetService<MainPage>();
        Application.Current.OpenWindow(new Window
        {
            Page = newPage
        });
    }

    [RelayCommand]
    private async void ShowPopup()
    {
        var result = await this._popupService.ShowPopupAsync(this._popupContainerId);
    }

    public void SetPopupContainerId(Guid popupContainerId)
    {
        this._popupContainerId = popupContainerId;
    }
}
