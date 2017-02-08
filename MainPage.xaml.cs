using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

namespace Pidu
{

    public sealed partial class MainPage : Page
    {
        Korter korter1 = new Korter();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void lisaButton_Click(object sender, RoutedEventArgs e)
        {
            /*  List<string> massiiv = new List<string>();
              massiiv.Add("mari");
              massiiv.Add("kalle");
              string tekst = "";
              for (int i = 0; i < massiiv.Count; i++)
              {
                  tekst = tekst + massiiv[i].ToString() + " ∙ "; 
              }
              textblock1.Text = tekst; */
            if (!string.IsNullOrWhiteSpace(textbox1.Text))
            {
            korter1.lisaInimene(textbox1.Text);
            textbox1.Text = "";
            textblock1.Text = korter1.kuvaInimesed();
            }
            else
            {
                var dialog = new MessageDialog("Sul on nimi ka ju raibe!");
                dialog.ShowAsync();
            }
        }

        private void eemaldaButton_Click(object sender, RoutedEventArgs e)
        {
            korter1.eemaldaInimene(textbox1.Text);
            textbox1.Text = "";
            textblock1.Text = korter1.kuvaInimesed();
        }
    }
}
