# Big-O Notation

How efficient is your code?

### **O(1) → Constant time complexty**

- Assignment 
- Seclaration
- Arithmetc
- Comparation
- Accessing Element
- Calling Function

### O(N) - Linear

- Think “for loop”
- Number od inputs increase time
- ex: int total = 0 → while (i ≤10 ) **O(N)**

### O(N^2)

- For loop insede of another for loop

  # Array

### Adding in array

In the end of array
```c#
for (int i = 0; i <  3; i++)
{
    intArray[length] = i + 1 ;
    length++;
}
```

In the start array

```c#
  for( int i = 3 ; i >= 0; i--)
{
    intArray[i + 1] = intArray[i];
}

intArray[0] = 20 ;
```
In the sprcific space
```c#
  for (int i = 4; i >= 2; i--)
{
    intArray[i + 1] = intArray[i];
}

intArray[1] = 8;
```

