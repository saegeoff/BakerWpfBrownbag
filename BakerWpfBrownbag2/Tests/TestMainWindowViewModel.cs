using BakerWpfBrownbag.Models;
using BakerWpfBrownbag.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerWpfBrownbag.Tests
{
    class TestMainWindowViewModel
    {
        public void Test()
        {
            MainWindowViewModel vm = new MainWindowViewModel(new MatlConcrete());

            
        }
    }
}
