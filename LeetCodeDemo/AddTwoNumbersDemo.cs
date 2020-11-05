using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeDemo
{
    //给出两个 非空 的链表用来表示两个非负的整数。其中，它们各自的位数是按照 逆序 的方式存储的，并且它们的每个节点只能存储 一位 数字。
    //如果，我们将这两个数相加起来，则会返回一个新的链表来表示它们的和。
    //您可以假设除了数字 0 之外，这两个数都不会以 0 开头。
    //示例：
    //输入：(2 -> 4 -> 3) + (5 -> 6 -> 4)
    //输出：7 -> 0 -> 8
    //原因：342 + 465 = 807
    public class AddTwoNumbersDemo
    {

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode l3 = new ListNode();
            ListNode cursor = l3;
            int temp = 0;//进位变量
            while (l1 != null || l2 != null || temp != 0)
            {
                var l1val = l1 != null ? l1.val : 0;//取当前节点数字
                var l2val = l2 != null ? l2.val : 0;
                var sumNumber = l1val + l2val + temp;//求和
                temp = sumNumber / 10;
                ListNode node = new ListNode(sumNumber % 10);
                cursor.next = node;
                cursor = node;
                if (l1 != null)
                {
                    l1 = l1.next;//将下一个节点信息放在上一个节点
                }
                if (l2 != null)
                {
                    l2 = l2.next;//将下一个节点信息放在上一个节点
                }
            }
            return l3.next;
        }
    }

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

}
