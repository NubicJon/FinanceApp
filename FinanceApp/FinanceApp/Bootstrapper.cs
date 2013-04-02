using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.MefExtensions;

namespace FinanceApp
{
    public class Bootstrapper : MefBootstrapper
    {
        protected override System.Windows.DependencyObject CreateShell()
        {
            var view = new Shell();
            App.Current.MainWindow = view;
            App.Current.MainWindow.Show();
            return view;
        }
    }
}
