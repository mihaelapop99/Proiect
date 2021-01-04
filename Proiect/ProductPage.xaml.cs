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
    public partial class ProductPage : ContentPage
    {
        ShopList sl;
        public ProductPage(ShopList slist)

        {
            InitializeComponent();
            sl = slist;
        }




        private async void Button_StergeleElementClicked(object sender, EventArgs e)
        {
            try
            {
                var selectedProductId = ((Button)sender).CommandParameter;
                var selectedProduct = App.Database.GetProductAsync((int)selectedProductId).Result;
                await App.Database.DeleteProductAsync(selectedProduct);

                //Forteaza reafisarea tuturor elementelor din list view
                OnAppearing();
            }
            catch
            {
                //lista produse
            }
        }




        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var product = (Product)BindingContext;
            await App.Database.SaveProductAsync(product);
            listView.ItemsSource = await App.Database.GetProductsAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var product = (Product)BindingContext;
            await App.Database.DeleteProductAsync(product);
            listView.ItemsSource = await App.Database.GetProductsAsync();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetProductsAsync();
        }


        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            Product p;
            if (e.SelectedItem != null)
            {
                p = e.SelectedItem as Product;
                var lp = new ListProduct()
                {
                    ShopListID = sl.ID,
                    ProductID = p.ID
                };
                await App.Database.SaveListProductAsync(lp);
                p.ListProducts = new List<ListProduct> { lp };

                await Navigation.PopAsync();
            }


        }
    }
}