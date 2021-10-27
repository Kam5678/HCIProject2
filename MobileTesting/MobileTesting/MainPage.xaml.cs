using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace MobileTesting
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var Hair = new List<string>
            {
                "regularHat.png", "policeHat.png", "hardHat.png", "graduationHat.png", "magicHat.png", "magicHat2.png", "pamelaHat.png",
            };

            var Glasses = new List<string>
            {
                "sunGlasses.png", "sunGlasses2.png", "vrGlasses.png", "readingEyeglasses.png"
            };

            var Mouths = new List<string>
            {
                "flatMouth.png", "grinMouth.png", "smileMouth.png", "openMouth.png", "tongueOut.png", "vampireMouth.png"
            };

            CarouselView1.ItemsSource = Hair;
            CarouselView2.ItemsSource = Glasses;
            CarouselView3.ItemsSource = Mouths;

            // if (Accelerometer.IsMonitoring)
            //     return;

            //Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;
            //Accelerometer.Start(SensorSpeed.UI);

        }


            private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
        {
            
           // LabelX.Text = e.Reading.Acceleration.X.ToString();
           // LabelY.Text = e.Reading.Acceleration.Y.ToString();
           // LabelZ.Text = e.Reading.Acceleration.Z.ToString();

           
        }

        int nig = 0;

        void CarouselView2_CurrentItemChanged(System.Object sender, Xamarin.Forms.CurrentItemChangedEventArgs e)
        {
            bool equal = String.Equals(CarouselView2.CurrentItem.ToString(), "sunGlasses2.png", StringComparison.InvariantCulture);

            if (equal){

                Lock.Source = "unlock.png";

            }

            if (!equal)
            {

                Lock.Source = "lock.png";

            }

        }


    }


}
