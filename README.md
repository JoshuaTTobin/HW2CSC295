# HW2

Include a brief write-up (300-400 words) discussing your approach, challenges faced, and how you overcame them. This write-up should be included within the README.md of  your code repository.


 Linear Search looks at each item in order until it finds what it's looking for. If you're searching for a name in a book and you start at the beginning and go page by page until you find the name, that's like linear search. It works okay for small lists, but if there are a lot of names, it takes longer because you have to check each one, one after another. This is called O(n) time complexity, where 'n' is the number of names.

 Binary Search is like Imagining a real life dicinary or book is already sorted alphabetically. Binary search is like starting in the middle of the phone book. If the name you're looking for is after the middle, you only need to look in half of the book. Then you keep dividing the remaining section in half until you find the name. This method is much faster for large lists because you cut down the number of checks you have to make each time. Binary search has a time complexity of O(log n), which means it gets faster even as the list gets bigger.

 I Chose Binary Search for this assingment and decided thatt is would be more efficent because it's faster for big lists. But the list must be sorted beforehand. Sorting takes time, but once it's sorted, searching becomes more efficent. This trade-off between sorting first and fast searching later seems like it become a priority for more complex programs.

 During my project, I faced some tough problems that helped me learn more about writing code. For instance, when I divided the list in half, I needed to ensure I did it correctly. This involved checking conditions like whether a number was even or odd, or making sure that two items in the list were equal to each other.
 
 To make sure my program worked well, I tested it with different kinds of lists—small ones with only a few names and big ones with lots of names. Testing helped me see if my code could handle all situations and find names accurately every time. After Putting It All Together, I organized the binary search code neatly in a class called SingleElementFinder. This made it easier to understand and use whenever I needed to find a specific name in a sorted list of names.

 Learning about linear and binary search taught me how important it is to use efficient methods while working on computer programs. Binary search, with its smart way of searching through sorted lists, is great for programs that need to find things quickly and accurately, especially when dealing with lots of data. Testing and solving problems together with others helped me make sure my program was strong and reliable for any situation. 

