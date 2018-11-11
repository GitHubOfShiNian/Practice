using System;

namespace ConsolePractice
{
    public class Stack
    {
        Entry top;
        public void Push(object data)
        {
            top = new Entry(top, data);
        }
        public object Pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException();
            }
            object result = top.data;
            top = top.next;
            var s = new SIOrderInfo
            {
                OrderCode = "",
                CreatedTime = DateTime.Now,
                MBLNo = ""
            };
            return result;
        }
        class Entry
        {
            public Entry next;
            public object data;
            public Entry(Entry next, object data)
            {
                this.next = next;
                this.data = data;
            }
            
        }
        public class OrderInfo
        {
            public string OrderCode { get; set; }
            public DateTime CreatedTime { get; set; }
        }
        public class SIOrderInfo:OrderInfo
        {
            public string MBLNo { get; set; }
        }
    }
}
