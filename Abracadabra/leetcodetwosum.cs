using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abracadabra
{
    public class leetcodetwosum
    {
        public static void Main()
        {
            ListNode[] l1_arr = new ListNode[3].Select(l => new ListNode(5)).ToArray();
            ListNode[] l2_arr = new ListNode[3].Select(l => new ListNode(6)).ToArray();
            for(int i = 0; i < l1_arr.Length - 1; i++)
            {
                l1_arr[i].next = l1_arr[i + 1];
                l2_arr[i].next = l2_arr[i + 1];
            }
            ListNode ans = new Solution().AddTwoNumbers(l1_arr[0], l2_arr[0]);
            printNodes(l1_arr[0]);
            printNodes(l2_arr[0]);
            printNodes(ans);
            

        }
        public static void printNodes(ListNode p1)
        {
            Console.Write("[");
            while (p1 != null)
            {
                Console.Write(p1.val + ", ");
                p1 = p1.next;
            }
            Console.Write("]\n");
        }
    }
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode ans = new ListNode();
            ListNode n1 = ans;
            bool nullCheck = true;
            int carry = 0;
            while (nullCheck)
            {
                int sum = 0;
                sum += carry;
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                carry = sum/10;
                sum = sum % 10;
                n1.val = sum;
                if (l1 != null || l2 != null || carry != 0)
                {
                    ListNode temp = new ListNode();
                    n1.next = temp;
                    n1 = temp;
                }
                else
                {
                    nullCheck = false;
                }
            }
            return ans;
        }
    }
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
 }
}
