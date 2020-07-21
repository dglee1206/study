using System;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Random rand = new Random();
        byte[] rgb = new byte[3];

        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnTapped(TappedRoutedEventArgs args)
        {
            if (args.OriginalSource is TextBlock)
            {
                TextBlock txtblk = args.OriginalSource as TextBlock;
                rand.NextBytes(rgb);
                Color clr = Color.FromArgb(255, rgb[0], rgb[1], rgb[2]);
                txtblk.Foreground = new SolidColorBrush(clr);
            }

            base.OnTapped(args);
        }
    }
}
