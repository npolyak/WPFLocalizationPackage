using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;

namespace Tomers.WPF.Localization
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			Data dataI = new Data("5");
			Data dataII = new Data("6");

			_elementI.Content = dataI;
			_elementII.Content = dataII;
		}

		public int Uid
		{
			get { return 4; }
		}

		protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
		{
			DragMove();
			base.OnMouseLeftButtonDown(e);
		}

		private void ButtonFlag_Click(object sender, RoutedEventArgs e)
		{
			if (LanguageContext.Instance.Culture == CultureInfo.GetCultureInfo("he-IL"))
			{
				LanguageContext.Instance.Culture = CultureInfo.GetCultureInfo("en-US");
			}
			else
			{
				LanguageContext.Instance.Culture = CultureInfo.GetCultureInfo("he-IL");
			}
		}		

		private void ButtonError_Click(object sender, RoutedEventArgs e)
		{
			string message = LanguageDictionary.Current.Translate<string>("NotEnoughMemory", "Message");
			MessageBox.Show(message);
		}
		private void ButtonClose_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown(0);
		}

	}
}
