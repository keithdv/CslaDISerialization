using Autofac;
using Csla;
using CslaDISerialization.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CslaDISerialization.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var formatter = (NetDataContractSerializerWrapper) Csla.Serialization.SerializationFormatterFactory.GetFormatter();


            var edit = DataPortal.Fetch<Edit>();

            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterModule<Lib.AutofacModule>();

            var container = builder.Build();

            formatter.SetState(container.BeginLifetimeScope());

            var newEdit = edit.Clone();
        }
    }
}
