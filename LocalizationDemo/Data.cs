using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace Tomers.WPF.Localization
{
	public class Data
	{
		private static int _sid = 0;

		private int _id = ++_sid;
		private string _uid;

		public int ID
		{
			get { return _id; }
		}

		public string Uid
		{
			get { return _uid; }
		}

		public Data(string uid)
		{
			this._uid = uid;
		}
	}
}
