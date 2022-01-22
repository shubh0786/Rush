using System;
using Xamarin.Forms;

namespace Rush
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private object NewItemPage()
        {
            throw new NotImplementedException();
        }

        private object ItemDetailPage()
        {
            throw new NotImplementedException();
        }
    }
}
