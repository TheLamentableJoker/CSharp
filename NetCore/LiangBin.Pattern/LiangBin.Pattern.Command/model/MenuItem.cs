using System;
using System.Collections.Generic;
using System.Text;

namespace LiangBin.Pattern.Command.model {
    public delegate void MessageShowEvent(string message);
    public class MenuItem {
        public event MessageShowEvent MessageShowEvent;
        
        public string Item { get; set; }
        public int Quantity { get; set; }
        public int TableNumber { get; set; }
        public List<Tag> Tags { get; set; }

        public void DisplayOrder() {
            MessageShowEvent?.Invoke("Table No: " + TableNumber);
            MessageShowEvent?.Invoke("Item: " + Item);
            MessageShowEvent?.Invoke("Quantity: " + Quantity);
            MessageShowEvent?.Invoke("\tTags: ");
            foreach (var item in Tags) {
                MessageShowEvent?.Invoke(item.TagName);
            }
        }
    }
    public class Tag {
        public string TagName { get; set; }
    }
}
