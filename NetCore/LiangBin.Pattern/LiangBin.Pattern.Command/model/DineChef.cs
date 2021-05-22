using System;
using System.Collections.Generic;
using System.Text;

namespace LiangBin.Pattern.Command.model {
	public class DineChef {
		private DineChefRestaurant DineChefRestaurant;
		private OrderCommand OrderCommand;
		private MenuItem MenuItem;
		public DineChef() {
			DineChefRestaurant = new DineChefRestaurant();
		}

		public void SetOrderCommand(int dineCommand) {
			OrderCommand = new DineTaleCommand().GetDineCommand(dineCommand);
		}
		public void SetMenuItemShowEvent(MessageShowEvent messageShow) {
			DineChefRestaurant.SetShowEvent(messageShow);
		}
		public void SetMenuItem(MenuItem menuItem,MessageShowEvent messageShow) {
			MenuItem = menuItem;
			MenuItem.MessageShowEvent += messageShow;
		}

		public void ExcuteCommand() {
			DineChefRestaurant.ExcuteCommand(OrderCommand,MenuItem);
		}

		public void ShowCurrentOrder() {
			DineChefRestaurant.ShowOrders();
		}
	}

	class DineTaleCommand {
		public OrderCommand GetDineCommand(int dineCommand) {
			switch (dineCommand) {
				case 1:
					return new NewOrderCommand();
				case 2:
					return new ModifyOrderCommand();
				case 3:
					return new RemoveOrderCommand();
				default:
					return new NewOrderCommand();
			}
		}
	}
}
