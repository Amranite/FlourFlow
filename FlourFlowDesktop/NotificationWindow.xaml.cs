﻿using Microsoft.EntityFrameworkCore.Query.Internal;
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
using System.Windows.Shapes;

namespace FlourFlowDesktop
{
	/// <summary>
	/// Interaction logic for NotificationWindow.xaml
	/// </summary>
	public partial class NotificationWindow : Window
	{
		public NotificationWindow(string message)
		{
			InitializeComponent();
			MessageTextBlock.Text = message;
		}

		private void OkButton_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}	
	}
}
