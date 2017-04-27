using Sockets.Plugin;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace GetAllNetworkInterfaces
{
	public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

		private async void Button_Click(object sender, RoutedEventArgs e)
		{
			var allInterfaces = await CommsInterface.GetAllInterfacesAsync();
		}
	}
}
