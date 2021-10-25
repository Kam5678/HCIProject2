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
            var names = new List<string> { "A", "B", "C", "D" };
            var Images1 = new List<string>
            {
                "sunGlasses.png", "sunGlasses2.png", "vrGlasses.png"
            };
            var Images2 = new List<string>
            {
                "glassesTest.jpg"
            };
            var Images3 = new List<string>
            {
                "glassesTest.jpg"
            };
            CarouselView1.ItemsSource = Images1;
            CarouselView2.ItemsSource = Images2;
            CarouselView3.ItemsSource = Images3;
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

        //public void ArrowPressed(object sender, EventArgs e)
        //{
        //    ImageButton thisButton = sender as ImageButton;
        //    Console.WriteLine(thisButton.ClassId);
        //    thisButton.Opacity = 0.5;
        //    if (thisButton.ClassId.Equals("Right1"))
        //    {
        //        //Console.WriteLine("R");
        //        Image1.TranslateTo(1000, Image1.Y, 600, Easing.CubicInOut); // With Animation

        //    }
        //    else if (thisButton.ClassId.Equals("Left1"))
        //    {
        //        //Console.WriteLine("RR");
        //        Image1.TranslateTo(0, Image1.Y, 600, Easing.CubicInOut); // Goes straight no animation
        //    }

        //}

        //public void ArrowReleased(object sender, EventArgs e)
        //{
        //    ImageButton thisButton = sender as ImageButton;
        //    thisButton.Opacity = 1;
        //}

        // Set speed delay for monitoring changes.

        
    }
}
