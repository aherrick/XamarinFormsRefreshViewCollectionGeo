using System.ComponentModel;
using Xamarin.Forms;
using XamarinFormsRefreshViewCollectionGeo.ViewModels;

namespace XamarinFormsRefreshViewCollectionGeo.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        private ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // if (viewModel.Items.Count == 0) // ensure we attempt to execute on load
            viewModel.LoadItemsCommand.Execute(null);
        }
    }
}