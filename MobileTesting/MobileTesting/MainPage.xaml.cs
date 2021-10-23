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
            thisButton.Opacity = 0.5;
        }

        public void ArrowReleased(object sender, EventArgs e)
        {
            ImageButton thisButton = sender as ImageButton;
            thisButton.Opacity = 1;
        }
    }
}
