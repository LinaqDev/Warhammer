﻿using System; 
using System.ComponentModel; 

namespace WarhammerClient
{
    public class BaseViewModel : INotifyPropertyChanged
	{

		public event PropertyChangedEventHandler PropertyChanged;
		protected void RaisePropertyChanged(string propertyname)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
		}

		public static event EventHandler<PropertyChangedEventArgs> StaticPropertyChanged;
		public static void RaiseStaticPropertyChanged(string propName)
		{
			EventHandler<PropertyChangedEventArgs> handler = StaticPropertyChanged;
			if (handler != null)
				handler(null, new PropertyChangedEventArgs(propName));

		}

	}
}
