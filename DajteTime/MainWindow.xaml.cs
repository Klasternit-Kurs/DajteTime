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

namespace DajteTime
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public DateTime Vreme { get; set; }

		public MainWindow()
		{
			InitializeComponent();
			Vreme = DateTime.Now;
			lbl.Content = Vreme.Day;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			DateTime VremeBuduce = Vreme.AddDays(7);
			lbl.Content = Vreme;
			if (VremeBuduce > Vreme)
			{
				MessageBox.Show("Jeste");
			}
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			DateTime VremeBuduce = Vreme.AddDays(7);
			VremeBuduce = VremeBuduce.AddHours(3);
			TimeSpan Period = new TimeSpan(8, 15, 3, 0);
			lbl.Content = Vreme + Period;

			//lbl.Content = Vreme - VremeBuduce;
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			nesto.Content = Vreme - datum.SelectedDate;
			
		}
	}
}
