using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proiect
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListEntryPage : ContentPage
    {
        public ListEntryPage()
        {
            InitializeComponent();
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetShopListsAsync();
        }
        async void OnShopListAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListPage
            {
                BindingContext = new ShopList()
            });
        }

        async void OnMagazineClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Magazine
            {
                BindingContext = new ShopList()
            });
        }
       

        //async void MagazineDisponibileClicked(object sender, EventArgs e)
        //{
        //listView.ItemsSource = await App.Database.GetShopListsAsync();
        // List<string> MahazineList = new List<string>();
        //MahazineList.Add("Mahesh Chand");
        //  }



        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ListPage
                {
                    BindingContext = e.SelectedItem as ShopList
                });
            }
        }







    }
}