using CommunityToolkit.Maui.Views;

namespace Maui.MultipleWindows.App.View;

public partial class MyPopup : Popup
{
	public MyPopup()
	{
		InitializeComponent();
	}

    private void CancelButton_Clicked(object sender, EventArgs e) => Close(false);

	private void ConfirmButton_Clicked(object sender, EventArgs e) => Close(true);
}