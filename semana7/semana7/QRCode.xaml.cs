﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semana7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRCode : ContentPage
    {
        public QRCode()
        {
            InitializeComponent();
        }
        private async void btnScan_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = DependencyService.Get<IQRCode>();
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    txtBarcode.Text = result;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}