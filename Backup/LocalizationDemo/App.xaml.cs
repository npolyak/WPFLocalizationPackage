using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Threading;
using System.Globalization;

namespace Tomers.WPF.Localization
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			LanguageDictionary.RegisterDictionary(
				CultureInfo.GetCultureInfo("en-US"),
				new XmlLanguageDictionary("Languages/en-US.xml"));

			LanguageDictionary.RegisterDictionary(
				CultureInfo.GetCultureInfo("he-IL"),
				new XmlLanguageDictionary("Languages/he-IL.xml"));

			LanguageContext.Instance.Culture = CultureInfo.GetCultureInfo("en-US");			

			base.OnStartup(e);
		}
	}
}
