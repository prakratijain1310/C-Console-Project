
#String
text = "hello"
result = []
for ch in text:
    result.append(ch)

result = "".join(result)
print(text)
print(result)  


#Set
num = [1,2,3,4,5]
seen =  set(num)
print (3 in seen)


#HashMap
def two_sum(arr, target):
    num_map = {}
    for i, num in enumerate(arr):
        complement = target - num 
        if complement in num_map:
            return [num_map[complement], i]
        num_map[num] = i

arr = [1,2,3,4,15]
target = 7
print(two_sum(arr, target))  


#Palindrome
def twoPointer(string):
    l,r = 0 , len(string)-1
    while l<r:
        while l<r and not string[l].isalnum():
            l+=1
        while l<r and not string[r].isalnum():
            r-=1
        if string[l].lower() != string[l].lower():
            return False
        l+=1
        r-=1
    return True
    
print(twoPointer("A man, a plan, a canal – Panama"))


#MiddleValue
class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
head = ListNode(1)
head.next = ListNode(2)
head.next.next = ListNode(3)
head.next.next.next = ListNode(4)
head.next.next.next.next = ListNode(5)

def middleValue(head):
    slow = fast = head
    while fast and fast.next:
        slow = slow.next
        fast = fast.next.next
    return slow

mid = middleValue(head)
print(mid.val) 
