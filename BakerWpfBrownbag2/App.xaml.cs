using BakerWpfBrownbag.Models;
using BakerWpfBrownbag.ViewModels;
using BakerWpfBrownbag.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BakerWpfBrownbag
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MatlConcrete m = new MatlConcrete();
            m.Name = "Name from the model!";
            m.Description = "Testing";
            m.CompressiveStrength28 = 1.0;
            m.InitialCompressiveStrength = 2.0;
            m.CoeffThermalExpansion = 3.0;
            m.DensityDeadLoad = 4.0;

            MainWindowView vw = new MainWindowView();
            MainWindowViewModel vm = new MainWindowViewModel(m);
            vw.DataContext = vm;
            vw.Show();
        }
    }
}
