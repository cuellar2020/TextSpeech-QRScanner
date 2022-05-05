using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace semana7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            item01.Clicked += async (object sender, EventArgs e) =>
            {
                await Navigation.PushAsync(new TextToSpeechDemo());
            };
            item02.Clicked += async (object sender, EventArgs e) =>
            {
                await Navigation.PushAsync(new QRCode());
            };



        }
    }
}