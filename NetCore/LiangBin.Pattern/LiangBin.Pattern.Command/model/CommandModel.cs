using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiangBin.Pattern.Command.model {
	public abstract class OrderCommand {
		public abstract void Excute(List<MenuItem> order, MenuItem newItem);
	}

	public class CommandModel {
	}

	public class NewOrderCommand : OrderCommand {
		public override void Excute(List<MenuItem> order, MenuItem newItem) {
			order.Add(newItem);
		}
	}

	public class RemoveOrderCommand : OrderCommand {
		public override void Excute(List<MenuItem> order, MenuItem newItem) {
			order.Remove(order.Where(v=>v.Item==newItem.Item).First());
		}
	}

	public class ModifyOrderCommand : OrderCommand {
		public override void Excute(List<MenuItem> order, MenuItem newItem) {
			var item = order.Where(x => x.Item == newItem.Item).First();
			item.Quantity = newItem.Quantity;
			item.Tags = newItem.Tags;
			item.TableNumber = newItem.TableNumber;
		}
	}
}
 