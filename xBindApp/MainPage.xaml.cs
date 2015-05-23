using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using xBindApp.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace xBindApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<Info> lista = new ObservableCollection<Info>();
        public MainPage()
        {
            this.InitializeComponent();

            lista.Add(new Info
            {
                id = 1,
                nome = "VISUAL STUDIO 2005",
                img = @"images/logoVS.jpg"
            });
            lista.Add(new Info
            {
                id = 2,
                nome = "VISUAL STUDIO 2008",
                img = @"images/logoVS2.jpg"
            });
            lista.Add(new Info
            {
                id = 3,
                nome = "VISUAL STUDIO 2010",
                img = @"images/logoVS3.jpg"
            });
            lista.Add(new Info
            {
                id = 4,
                nome = "VISUAL STUDIO 2012",
                img = @"images/logoVS4.png"
            });
            lista.Add(new Info
            {
                id = 5,
                nome = "VISUAL STUDIO 2013",
                img = @"images/logoVS5.png"
            });
            lista.Add(new Info
            {
                id = 6,
                nome = "VISUAL STUDIO 2015",
                img = @"images/logoVS6.png"
            });
            listBox.ItemsSource = lista;
        }
    }
}
