using System.Collections;
using System.Text;

namespace dotnet_exercises.LeetCode;

/*
 
You are given two non-empty linked lists representing two non-negative integers. 
The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example 1:
Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.

Example 2:

Input: l1 = [0], l2 = [0]
Output: [0]

Example 3:

Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]

Constraints:

The number of nodes in each linked list is in the range [1, 100].
0 <= Node.val <= 9
It is guaranteed that the list represents a number that does not have leading zeros.

*/

public class ListNode
{
    public int val { get; set; }
    public ListNode next { get; set; }

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution : IRunner
{
    // private ListNode n1 = new ListNode(5, new ListNode(6, new ListNode(4, null)));
    // private ListNode n2 = new ListNode(2, new ListNode(4, new ListNode(3, null)));
    // private ListNode n1 = new ListNode(0, null);
    // private ListNode n2 = new ListNode(1, null);
    private ListNode n1 = new ListNode(9, null);

    private ListNode n2 = new(1, new
    (9, new
    (9, new
    (9, new
    (9, new
    (9, new
    (9, new
    (9, new
    (9, new
        (9))))))))));

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        return null;
    }

    /// <summary>
    /// This solution don't work due ListNode being nested up to many times and casting combined value of all nested ListNode is bigger then max capacity of 'ulong' type.
    /// 1565 / 1568 testcases passed
    /// </summary>
    // public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    // {
    //     var StackOfNodeList1 = CreateStackFromListNode(l1);
    //     var StackOfNodeList2 = CreateStackFromListNode(l2);
    //
    //     var valueFromStack1 = ConvertStackValuesIntoNumber(StackOfNodeList1);
    //     var valueFromStack2 = ConvertStackValuesIntoNumber(StackOfNodeList2);
    //
    //     var resultStack = new List<ulong>();
    //     
    //     foreach (var c in (valueFromStack1 + valueFromStack2).ToString())
    //     {
    //         resultStack.Add(ulong.Parse(c.ToString()));
    //     }
    //
    //     var stacks = new List<ListNode>();
    //     ListNode listNode = null;
    //
    //     foreach (var result in resultStack)
    //     {
    //         if (stacks.Count == 0)
    //         {
    //             listNode = new ListNode((int)result, listNode);
    //             stacks.Add(listNode);
    //             continue;
    //         }
    //     
    //         var temp = new ListNode((int)result, listNode);
    //         stacks.Add(temp);
    //         listNode = temp;
    //     }
    //    
    //     
    //     
    //     return listNode;
    //
    //     ulong ConvertStackValuesIntoNumber(Stack<ulong> stack)
    //     {
    //         StringBuilder sb = new();
    //         while (stack.TryPop(out var result))
    //         {
    //             sb.Append(result.ToString());
    //         }
    //         ulong.TryParse(sb.ToString(), out var n);
    //         return n;
    //     }
    //
    //     Stack<ulong> CreateStackFromListNode(ListNode ln)
    //     {
    //         var listNode = ln;
    //         var stack = new Stack<ulong>();
    //         bool isLast = false;
    //         do
    //         {
    //             if(listNode == null) break;
    //
    //             isLast = listNode.next == null;
    //             if (isLast)
    //             {
    //                 stack.Push((ulong)listNode.val);
    //                 break;
    //             }
    //         
    //             stack.Push((ulong)listNode.val);
    //             listNode = listNode.next;
    //
    //         } while(!isLast);
    //
    //         return stack;
    //     }
    // }


    public void Run()
    {
        AddTwoNumbers(n1, n2);
    }
}