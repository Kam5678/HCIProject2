using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileTesting
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void ArrowPressed(object sender, EventArgs e)
        {
            ImageButton thisButton = sender as ImageButton;
            Console.WriteLine(thisButton.ClassId);
            thisButton.Opacity = 0.5;
            if (thisButton.ClassId.Equals("Right1"))
            {
                //Console.WriteLine("R");
                Image1.TranslateTo(1000, Image1.Y, 600, Easing.CubicInOut); // With Animation
  
            }
            else if (thisButton.ClassId.Equals("Left1"))
            {
                //Console.WriteLine("RR");
                Image1.TranslateTo(0, Image1.Y, 600, Easing.CubicInOut); // Goes straight no animation
            }
            
        }

        public void ArrowReleased(object sender, EventArgs e)
        {
            ImageButton thisButton = sender as ImageButton;
            thisButton.Opacity = 1;
        }
    }
}
