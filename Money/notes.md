left off on Chapter 3, page 15

## Todo

- $5 + 10 CHF = $10 if rate is 2:1
- ~~$5 * 2 = $10~~
- ~~make "amount" private~~
- ~~Dollar side effects?~~
- Money rounding?
- ~~equals()~~
- Equal null
- Equal object
- hashCode()
- ~~5 CHF * 2 = 10 CHF~~

## Lessons
- The problem is dependency (between the code and test). The sympton is duplication. Get rid of the duplication, and you get rid of the dependency and end up with more generalized code.
- TDD is about *being able* to take teeny-tiny steps. When things get weird, you'll be glad you can.
- Generalizing code
  - replacing constants with variables
- First we'll solve the "that works" part of the problem. Then we'll solve the "clean code" part of the problem.
  - this is the opposite of architecture-driven development
- Strategies for quickly getting to green
  - fake it - return a constant and gradually replace constants with variables until you have the real code
  - use obvious implementation - type in the real implementation
  - triangulation - we only generalize code when we have 2 or more examples.
    - when the design thoughts just aren't coming, triangulation provides a chance to think about the problem from a slightly different direction.
- Value Objects - using objects as values
  - constraints
    - the values of the instance variables never change once they have been set by the constructor
  - implications
    - all operations must return a new object
    - Value Objects should implement equals() method