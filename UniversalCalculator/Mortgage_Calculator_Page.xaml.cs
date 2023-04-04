using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class Mortgage_Calculator_Page : Page
	{
		public Mortgage_Calculator_Page()
		{
			this.InitializeComponent();
		}

		private void calculateButton_Click(object sender, RoutedEventArgs e)
		{
			double P = double.Parse(principalBorrow.Text);
			double i;
			double n;
			double y = double.Parse(yearlyInterestRate.Text);
			double t = double.Parse(years.Text);
			i = (y / 100) / 12;
			n = t * 12;
			double M;

			M = (P * i) / (1 - 1 / Math.Pow(1 + i, t * 12));

			andMonths.Text = n.ToString();
			monthlyInterestRate.Text = i.ToString("p");
			monthlyRepayment.Text = M.ToString("C");
		}

		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			System.Environment.Exit(0);
		}
	}
}
