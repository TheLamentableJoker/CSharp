using System;
using System.Collections.Generic;
using System.Text;

namespace LiangBin.Pattern.Command.model {
	public class DineChefRestaurant {
		public List<MenuItem> Orders { get; set; }

		public DineChefRestaurant() {
			Orders = new List<MenuItem>();
		}

		public void ExcuteCommand(OrderCommand orderCommand,MenuItem menuItem) {
			orderCommand.Excute(Orders,menuItem);
		}
		public void ShowOrders() {
			foreach (var item in Orders) {
				item.DisplayOrder();
			}
		}

		public void SetShowEvent(MessageShowEvent messageShow) {
			foreach (var item in Orders) {
				item.MessageShowEvent+= messageShow;
			}
		}

	}
}
