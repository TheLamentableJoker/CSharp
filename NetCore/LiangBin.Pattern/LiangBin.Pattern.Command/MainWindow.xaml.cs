using LiangBin.Pattern.Command.model;
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
using MenuItem = LiangBin.Pattern.Command.model.MenuItem;

namespace LiangBin.Pattern.Command {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e) {
            DineChef dineChef = new DineChef();
            dineChef.SetOrderCommand(1); /* Insert Order */
            dineChef.SetMenuItem(new MenuItem() {
				TableNumber = 1,
				Item = "Super Mega Burger",
				Quantity = 1,
				Tags = new List<Tag>() { new Tag() { TagName = "Jalapenos," }, new Tag() { TagName = " Cheese," }, new Tag() { TagName = " Tomato" } },

			}, (msg) => {
                currentRichTextBox.AppendText(msg);
                currentRichTextBox.LineDown();
            });
            dineChef.ExcuteCommand();

            dineChef.SetOrderCommand(1); /* Insert Order */
            dineChef.SetMenuItem(new MenuItem() {
                TableNumber = 1,
                Item = "Cheese Sandwich",
                Quantity = 1,
                Tags = new List<Tag>() { new Tag() { TagName = "Spicy Mayo," } }
            }, (msg) => {
                currentRichTextBox.AppendText(msg);
                currentRichTextBox.LineDown();
            });
            dineChef.ExcuteCommand();
            dineChef.ShowCurrentOrder();

            dineChef.SetOrderCommand(3); /* Remove the Cheese Sandwich */
            dineChef.SetMenuItem(new MenuItem() {
                TableNumber = 1,
                Item = "Cheese Sandwich"
            }, (msg) => {
                currentRichTextBox.AppendText(msg);
                currentRichTextBox.LineDown();
            });
            dineChef.ExcuteCommand();
            dineChef.ShowCurrentOrder();

            dineChef.SetOrderCommand(2);/* Modify Order */
            dineChef.SetMenuItem(new MenuItem() {
                TableNumber = 1,
                Item = "Super Mega Burger",
                Quantity = 1,
                Tags = new List<Tag>() { new Tag() { TagName = "Jalapenos," }, new Tag() { TagName = " Cheese" } }
            }, (msg) => {
                currentRichTextBox.AppendText(msg);
                currentRichTextBox.LineDown();
            });
            dineChef.ExcuteCommand();
            dineChef.ShowCurrentOrder();
        }

		private void MainWindow_MessageShowEvent(string message) {
			throw new NotImplementedException();
		}
	}
}
