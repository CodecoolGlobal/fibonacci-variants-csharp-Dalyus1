# Fibonacci variants

## Story

Your friend, who just started to learn programming, says that he
doesn't understand the hype around this recursion thing.
He completed the Fibonacci exercise using recursion, which runs A LOT
slower than the "normal" variant using loops. The program effectively
freezes when asked to calculate the 40th Fibonacci number.

You tell him that a well-implemented Fibonacci algorithm should
have an O(n) characteristic, using either loops or recursion.

He looks puzzled, so you explain this using plain words: so, this means that in order
to calculate the 400th number, only cca. 400 basic steps – in this case: additions –
are needed. The key here is _to avoid repeating operations_, which means that
the program needs to store every piece of data that can used later.

A mentor walks around and says that this technique is called _memoization_
which is related to _dynamic programming_. The situation quickly
deteriorates when another mentor – the geekiest one – joins the group
and argues that a proper recursive solution, a _tail-recursive_ solution,
does not require extra memory at all. They start shouting at each other
around the topic of something called _tail-call optimization_, the end up
badmouthing each others' favorite programming language. Gross.

The two of you leave the scene unnoticed, and decide to dive deeper
into this topic together, reconstructing the various solutions to the
Fibonacci problem.

> We define `Fib(0) = 0` and `Fib(1) = 1` here, so `Fib(5)` should return `5`,
> `Fib(6) = 8`, and `Fib(7) = 13`.
> The series starts like (0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, ...)

## What are you going to learn?

- Analyze algorithmic behavior.
- Calculate the computational complexity of an algorithm.
- Understand recursion.
- Understand memoization.
- Understand tail recursion.

## Tasks

1. Implement a method that takes a single integer value and returns the corresponding Fibonacci number. Do not use recursion this time.
    - The returned value is the corresponding number from the Fibonacci sequence. There is no recursive call in the implementation.
    - The number of addition operations needed for the result are counted and printed.

2. Implement a method that takes a single integer value and returns the corresponding Fibonacci number. Use recursion (the original Fibonacci formula) but no extra memory during the calculation.
    - The returned value is the corresponding number from the Fibonacci sequence. The implementation uses no loops and no extra memory (such as global variables or extra parameters).
    - The number of addition operations needed for the result are counted and printed.

3. Enhance the `Fib` recursive method with a way to scale down the computational complexity.
    - The returned value is the corresponding number from the Fibonacci sequence. The implementation uses no loops but uses extra memory (such as global variables or extra parameters).
    - The number of addition operations needed for the result are counted and printed.

4. Rewrite the recursive method that using only one recursive call, the last expression in the return statement.
    - The returned value is the corresponding number from the Fibonacci sequence. The implementation uses no loops, no global variables but its performance is the same as that of the iterative solution.
    - The number of addition operations needed for the result are counted and printed.

## General requirements

None

## Hints

- Draw the contents of the call stack to help you visualize the number of method calls needed in a recursive algorithm.
- In case of the memoized version doesn't calculate the same Fibonacci number twice,
  store it in the memory in an easily accessible form, such as an array or a dictionary.
- Tail recursion means that the very last action in a function (and only that) is a recursive
  call. It's tricky, but the Fibonacci problem can be solved this way. Use multiple
  arguments and/or helper functions!
- Make sure not to get lost in the details of tail call optimization.
  Tail call optimization (TCO) is an important feature of a compiler or an interpreter
  that makes subsequent function calls more effective.

## Background materials

- <i class="far fa-exclamation"></i> [Fibonacci numbers](https://en.wikipedia.org/wiki/Fibonacci_number)
- <i class="far fa-exclamation"></i> [Memoization](https://en.wikipedia.org/wiki/Memoization)
- <i class="far fa-exclamation"></i> [Tail call](https://en.wikipedia.org/wiki/Tail_call)
