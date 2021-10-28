using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Threading;

namespace MobileTesting
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var Hair = new List<string>
            {
                // regulatHat, hardHat, cowboyHat, magicHat, magicHat2, pamelaHat
                "regularHat.png", "policeHat.png", "hardHat.png", "graduationHat.png", "cowboyHat.png", "magicHat.png", "magicHat2.png", "pamelaHat.png",
            };

            var Glasses = new List<string>
            {
                "sunGlasses.png", "sunGlasses2.png", "sunGlasses3.png", "sunGlasses4.png", "sunGlasses5.png", "vrGlasses.png", "readingEyeglasses.png"
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

        bool correctHat = false;
        bool correctGlasses = false;
        bool correctMouth = false;

        void KillProgram() {
            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
        }

        async void CorrectCombo()
        {
            if (correctHat && correctGlasses && correctMouth)
            {
                Lock.Source = "unlock.png";

                await Task.Delay(2000);


                KillProgram();
            }

            else
            {
                Lock.Source = "lock.png";
            }

        }

        void CarouselView1_CurrentItemChanged(System.Object sender, Xamarin.Forms.CurrentItemChangedEventArgs e)
        {
            string currentHat = CarouselView1.CurrentItem.ToString();

            bool equal = String.Equals(currentHat, "policeHat.png", StringComparison.InvariantCulture);

            if (equal){

                correctHat = true;
            }

            else {

                correctHat = false;

            }

            CorrectCombo();


            // "regularHat.png", "policeHat.png", "hardHat.png", "graduationHat.png", "cowboyHat.png", "magicHat.png", "magicHat2.png", "pamelaHat.png",

            if (String.Equals(currentHat, "regularHat.png", StringComparison.InvariantCulture)) {

                whiteRectangle.Margin = new Thickness(0,60,0,85);
            }

            if (String.Equals(currentHat, "policeHat.png", StringComparison.InvariantCulture))
            {
                whiteRectangle.Margin = new Thickness(0, 60, 0, 110);
            }

            if (String.Equals(currentHat, "hardHat.png", StringComparison.InvariantCulture))
            {
                whiteRectangle.Margin = new Thickness(0, 60, 0, 85);
            }

            if (String.Equals(currentHat, "graduationHat.png", StringComparison.InvariantCulture))
            {
                whiteRectangle.Margin = new Thickness(1000, 1000, 1000, 1000);
            }

            if (String.Equals(currentHat, "cowboyHat.png", StringComparison.InvariantCulture))
            {
                whiteRectangle.Margin = new Thickness(0, 60, 0, 95);
            }

            if (String.Equals(currentHat, "magicHat.png", StringComparison.InvariantCulture))
            {
                whiteRectangle.Margin = new Thickness(0, 60, 0, 70);
            }

            if (String.Equals(currentHat, "magicHat2.png", StringComparison.InvariantCulture))
            {
                whiteRectangle.Margin = new Thickness(0, 60, 0, 70);
            }

            if (String.Equals(currentHat, "magicHat2.png", StringComparison.InvariantCulture))
            {
                whiteRectangle.Margin = new Thickness(0, 60, 0, 70);
            }

        }

        void CarouselView2_CurrentItemChanged(System.Object sender, Xamarin.Forms.CurrentItemChangedEventArgs e)
        {
            bool equal = String.Equals(CarouselView2.CurrentItem.ToString(), "sunGlasses2.png", StringComparison.InvariantCulture);

            if (equal){

                correctGlasses = true;

            }

            else
            {

                correctGlasses = false;

            }

            CorrectCombo();

        }

        void CarouselView3_CurrentItemChanged(System.Object sender, Xamarin.Forms.CurrentItemChangedEventArgs e)
        {
            bool equal = String.Equals(CarouselView3.CurrentItem.ToString(), "grinMouth.png", StringComparison.InvariantCulture);

            if (equal)
            {

                correctMouth = true;

            }

            else
            {

                correctMouth = false;

            }

            CorrectCombo();

        }
    }


}
