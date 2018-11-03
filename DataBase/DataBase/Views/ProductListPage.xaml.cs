using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductListPage : ContentPage
    {
        public ProductListPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ((App)App.Current).ResumeAtToId = -1;
            listView.ItemsSource = await App.Database.GetItemsAsync();
        }

        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductItemPage
            {
                BindingContext = new ProductModel()
            });
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ProductItemPage
                {
                    BindingContext = e.SelectedItem as ProductModel
                });
            }
        }
    }
}