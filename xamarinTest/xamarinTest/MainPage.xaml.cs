using Android.App;
using Android.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace xamarinTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int count = 0;
        void Button_Clicked(object sender, System.EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You clicked {count} times.";
        }

        void aboutScreen(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new aboutScreen());
        }

        void votingScreen(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new votingScreen());
        }

        void hostScreen(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new hostScreen());
        }

        void takeActionScreen(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new takeAction());
        }

        


    }
}
