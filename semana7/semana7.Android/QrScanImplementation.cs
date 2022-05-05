using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using semana7.Droid;
using Xamarin.Forms;
using System.Threading.Tasks;
using ZXing.Mobile;
[assembly: Dependency(typeof(semana7.Droid.QrScanImplementation))]
namespace semana7.Droid
{
    class QrScanImplementation : IQRCode
    {

        public async Task<string> ScanAsync()
        {
            var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scaner = new MobileBarcodeScanner()
            {
                TopText = "Scan the QR Code",
                BottomText = "Please Wait",
            };

            var scanResult = await scaner.Scan(optionsCustom);
            return scanResult.Text;
        }
    }
}