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
	public sealed partial class Currency_Conversion_Calculator_Page : Page
	{
		public Currency_Conversion_Calculator_Page()
		{
			this.InitializeComponent();
		}
		private void Converter_Click(object sender, RoutedEventArgs e)
		{
			double tot;
			double amount = double.Parse(Amountenter.Text);

			// Euro to other Currency rate
			double US_Dollar = 1.1739732;
			double British_Pound = 0.8556672;
			double Indian_Rupee = 87.00755;

			//US Dollar to other currency rate
			double Euro = 0.85189982;
			double British = 0.72872436;
			double INR = 74.257327;

			// Indian Rupee to other currency rate
			double USD = 0.011492628;
			double EU = 0.013492774;
			double GBP = 0.0098339397;

			// British Pound to other currency rate
			double Rupee = 101.68635;
			double Dollar = 1.371907;
			double EUR = 1.1686692;




			// From Euro convert to other Currency Method

			if (From.Text == "EUR - Euro" && To.Text == "USD - US Dollar")
			{

				tot = amount * US_Dollar;
				Display_txt.Text = "$" + tot.ToString() + " " + "US Dollar";
				Amount_Result.Text = amount.ToString() + " " + "Euro" + " " + " = ";
				FromEx.Text = "1 Euro = 1.1739732 US Dollar";
				ToEx.Text = "1 US Dollar = 0.85189982 Euro";

			}

			if (From.Text == "EUR - Euro" && To.Text == "GBP - British Pound")
			{

				tot = amount * British_Pound;
				Display_txt.Text = "£" + tot.ToString() + " " + "British Pound";
				Amount_Result.Text = amount.ToString() + " " + "Euro" + " " + " = ";
				FromEx.Text = "1 Euro = 0.8556672 British Pound";
				ToEx.Text = "1 British Pound = 1.1686692 Euro";
			}

			if (From.Text == "EUR - Euro" && To.Text == "INR - Indian Rupee")
			{

				tot = amount * Indian_Rupee;
				Display_txt.Text = "₹" + tot.ToString() + " " + "Indian Rupee";
				Amount_Result.Text = amount.ToString() + " " + "Euro" + " " + " = ";
				FromEx.Text = "1 Euro =  87.00755 Indian Rupee";
				ToEx.Text = "1 Indian Rupee = 0.013492774 Euro";
			}

			// From US Dollar convert to other Currency Method

			if (From.Text == "USD - US Dollar" && To.Text == "EUR - Euro")
			{

				tot = amount * Euro;
				Display_txt.Text = "€" + tot.ToString() + " " + "EUR Euro";
				Amount_Result.Text = amount.ToString() + " " + "US Dollar" + " " + " = ";
				FromEx.Text = "1 US Dollar = 0.85189982 Euro";
				ToEx.Text = "1 Euro = 1.1739732 US Dollar";
			}
			if (From.Text == "USD - US Dollar" && To.Text == "GBP - British Pound")
			{

				tot = amount * British;
				Display_txt.Text = "£" + tot.ToString() + " " + "British Pound";
				Amount_Result.Text = amount.ToString() + " " + "US Dollar" + " " + " = ";
				FromEx.Text = "1 US Dollar = 0.8556672 British Pound";
				ToEx.Text = "1 British Pound = 1.371907 US Dollar";
			}
			if (From.Text == "USD - US Dollar" && To.Text == "INR - Indian Rupee")
			{

				tot = amount * INR;
				Display_txt.Text = "₹" + tot.ToString() + " " + "Indian Rupee";
				Amount_Result.Text = amount.ToString() + " " + "US Dollar" + " " + " = ";
				FromEx.Text = "1 US Dollar = 74.257327 Indian Rupee";
				ToEx.Text = "1 Indian Rupee = 0.011492628";
			}

			// From Indian Rupee convert to other currency Method
			if (From.Text == "INR - Indian Rupee" && To.Text == "USD - US Dollar")
			{

				tot = amount * USD;
				Display_txt.Text = "$" + tot.ToString() + " " + "US Dollar";
				Amount_Result.Text = amount.ToString() + " " + "Indian Rupee" + " " + " = ";
				FromEx.Text = "1 Indian Rupee = 0.011492628 US Dollar";
				ToEx.Text = "1 US Dollar =74.257327 Indian Rupee";
			}

			if (From.Text == "INR - Indian Rupee" && To.Text == "GBP - British Pound")
			{

				tot = amount * GBP;
				Display_txt.Text = "£" + tot.ToString() + " " + "British Pound";
				Amount_Result.Text = amount.ToString() + " " + "Indian Rupee" + " " + " = ";
				FromEx.Text = "1 Indian Rupee = 0.0098339397 British Pound";
				ToEx.Text = "1 British Pound  = 101.68635 Indian Rupee";
			}

			if (From.Text == "INR - Indian Rupee" && To.Text == "EUR - Euro")
			{

				tot = amount * EU;
				Display_txt.Text = "€" + tot.ToString() + " " + "Euro";
				Amount_Result.Text = amount.ToString() + " " + "Indian Rupee" + " " + " = ";
				FromEx.Text = "1 Indian Rupee = 0.013492774 Euro";
				ToEx.Text = "1 Euro = 87.00755 Indian Rupee";
			}

			// From British Pound convert to other currency Method
			if (From.Text == "GBP - British Pound" && To.Text == "INR - Indian Rupee")
			{

				tot = amount * Rupee;
				Display_txt.Text = "₹" + tot.ToString() + " " + "Indian Rupee";
				Amount_Result.Text = amount.ToString() + " " + "British Pound" + " " + " = ";
				FromEx.Text = "1 British Pound = 101.68635 Indian Rupee";
				ToEx.Text = "1 Indian Rupee = 0.0098339397 British Pound";

			}

			if (From.Text == "GBP - British Pound" && To.Text == "USD - US Dollar")
			{

				tot = amount * Dollar;
				Display_txt.Text = "$" + tot.ToString() + " " + "US Dollar";
				Amount_Result.Text = amount.ToString() + " " + "British Pound" + " " + " = ";
				FromEx.Text = "1 British Pound = 1.371907 US Dollar";
				ToEx.Text = "1 US Dollar  = 0.72872436 British Pound";
			}

			if (From.Text == "GBP - British Pound" && To.Text == "EUR - Euro")
			{

				tot = amount * EUR;
				Display_txt.Text = "€" + tot.ToString() + " " + "Euro";
				Amount_Result.Text = amount.ToString() + " " + "British Pound" + " " + " = ";
				FromEx.Text = "1 British Pound = 1.1686692 Euro";
				ToEx.Text = "1 Euro  = 0.8556672 British Pound";
			}
		}

		private void Exit_Btn_Clicked(object sender, RoutedEventArgs e)
		{
			System.Environment.Exit(0);	
		}
	}
}