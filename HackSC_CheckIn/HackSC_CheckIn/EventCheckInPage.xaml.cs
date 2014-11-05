﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; // for ObservableCollection<>
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace HackSC_CheckIn
{
	public partial class EventCheckInPage : PhoneApplicationPage
	{
		HackathonEvent Event { get; set; }

		ObservableCollection<string> Hackers = new ObservableCollection<string>();

		public EventCheckInPage()
		{
			InitializeComponent();

			Event = (App.Current as App).Events_CurrentEvent;

			if(Event == null)
			{
				NavigationService.GoBack();
				return;
			}

			PageTitle.DataContext = Event;
		}
	}
}