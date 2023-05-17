namespace MaximumTwinSumLinkedList
{
    internal class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
                     }
        }

        public class MaximumTwinSumLinkedList
        {
            public int PairSum(ListNode head)
            {
                ListNode slow = head;
                ListNode fast = head;
                while (fast != null && fast.next != null)
                {
                    slow = slow.next;
                    fast = fast.next.next;
                }
                ListNode prevNode = null;
                while (slow != null)
                {
                    ListNode nextNode = slow.next;
                    prevNode = slow;
                    slow = nextNode;
                }
                int maxPairSum = int.MinValue;
                ListNode node = head;
                while (prevNode != null)
                {
                    maxPairSum = Math.Max(maxPairSum, node.val + prevNode.val);
                    node = node.next;
                    prevNode = prevNode.next;
                }
                return maxPairSum;
            }
        }

        static void Main(string[] args)
        {
            ListNode testCase1 = new (5, new ListNode(4, new ListNode(2, new ListNode(1))));
            ListNode testCase2 = new (4, new ListNode(2, new ListNode(2, new ListNode(3))));
            ListNode testCase3 = new (1, new ListNode(100000));
            MaximumTwinSumLinkedList maximumTwinSumLinkedList = new();
            Console.WriteLine(maximumTwinSumLinkedList.PairSum(testCase1));
            Console.WriteLine(maximumTwinSumLinkedList.PairSum(testCase2));
            Console.WriteLine(maximumTwinSumLinkedList.PairSum(testCase3));
        }
    }
}