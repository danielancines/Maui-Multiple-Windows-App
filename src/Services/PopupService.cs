using CommunityToolkit.Maui.Views;
using Maui.MultipleWindows.App.View;

namespace Maui.MultipleWindows.App.Services
{
    public class PopupService
    {
        public PopupService()
        {
            this._pages = new Dictionary<Guid, Page>();
        }

        private Dictionary<Guid, Page> _pages;

        public void ShowPopup(Guid key)
        {
            if (_pages.TryGetValue(key, out Page page))
            {
                if (page != null)
                {
                    this.ShowPopup(page, new MyPopup());
                }
            }
        }

        public Guid RegisterPage(Page page)
        {
            if (this._pages.ContainsValue(page))
            {
                return this._pages.FirstOrDefault(k => k.Value == page).Key;
            }

            var newKey = Guid.NewGuid();
            this._pages.Add(newKey, page);

            return newKey;
        }

        private void ShowPopup(Page page, MyPopup popup)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                page.ShowPopup(popup);
            });
        }
    }
}
