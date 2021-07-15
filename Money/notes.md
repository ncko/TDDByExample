## Todo

- $5 + 10 CHF = $10 if rate is 2:1
- ~~$5 * 2 = $10~~
- make "amount" private
- ~~Dollar side effects?~~
- Money rounding?

## Lessons
- The problem is dependency (between the code and test). The sympton is duplication. Get rid of the duplication, and you get rid of the dependency and end up with more generalized code.
- TDD is about *being able* to take teeny-tiny steps. When things get weird, you'll be glad you can.
- Generalizing code
  - replacing constants with variables
- First we'll solve the "that works" part of the problem. Then we'll solve the "clean code" part of the problem.
  - this is the opposite of architecture-driven development