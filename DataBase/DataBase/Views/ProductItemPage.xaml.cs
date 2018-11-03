using DataBase;
using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBase.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProductItemPage : ContentPage
	{
		public ProductItemPage ()
		{
			InitializeComponent ();
		}

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var todoItem = (ProductModel)BindingContext;
            await App.Database.SaveItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var todoItem = (ProductModel)BindingContext;
            await App.Database.DeleteItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        void OnSpeakClicked(object sender, EventArgs e)
        {
            var todoItem = (ProductModel)BindingContext;
            DependencyService.Get<ITextToSpeech>().Speak(todoItem.Name + " " + todoItem.Description + " " + todoItem.Price);
        }

    }
}