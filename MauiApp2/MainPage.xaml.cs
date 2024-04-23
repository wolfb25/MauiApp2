using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace Utasszallitok2
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<string> results = new ObservableCollection<string>();
        public MainPage()
        {
            InitializeComponent();
            resultList.ItemsSource = results;
        }


        private void CalculateMachNumber(object sender, EventArgs e)
        {
            try
            {
                double q = double.Parse(torlo.Text);
                double p = double.Parse(statik.Text);
                double m = Math.Sqrt(5 * (Math.Pow(q / p + 1, 2.0 / 7) - 1));
                if (m < 1)
                {
                    results.Add($"qc={q} p0={p} Ma={m}");
                }
                else
                {
                    DisplayAlert("Hiba", "A Mach-szám értéke nagyobb vagy egyenlő mint 1.", "OK");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Hiba", ex.Message, "OK");
            }
        }

    }
}
