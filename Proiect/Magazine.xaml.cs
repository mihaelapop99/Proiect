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
    public partial class Magazine : ContentPage
    {
        public Magazine()
        { 
            //this.BindingContext = new Mgz();
            InitializeComponent();


            //this.BindingContext.Add(new Mgz
            //{
            //    Denumire = "Auchan",
            //    Description = "Iulius Mall Cluj-Napoca"
            //}
            //); 



            //new Mgz() { ID = 0, Denumire = "Auchan", Description = "Iulius Mall Cluj-Napoca" };
            //new Mgz() { ID = 1, Denumire = "Cora", Description = "Vivo Cluj-Napoca" };
        }

        //private void button1_Click(object sender, RoutedEventArgs e)
       // {
        //    listBox1.Items.Add(textBox1.Text);
        //}





        //protected override async void OnAppearing()
        //{
        // base.OnAppearing();
        //var shopl = (Mgz)BindingContext;


        //}
    }
}