# Scrabble
##### By Wei Dai and Misaki Koonce
###### Created 19 December, 2019
 
## Description
Make a console application that takes a word and returns the Scrabble score for that word.
[Scrabble](https://en.wikipedia.org/wiki/Scrabble) is a word game in which two to four players score points by placing tiles, each bearing a single letter, onto a game board divided into a 15×15 grid of squares

### Score Table
| Input | Score |
| :------------- | :------------- |
| A, E, I, O, U, L, N, R, S, T  | 1 |
| D, G | 2 |
| B, C, M, P | 3 |
| F, H, V, W, Y  | 4 |
| K | 5 |
| J, X | 8 |
| Q, Z  | 10 |

## Unit Testing
Receive the score of a number when the player enters the corresponding letter. For instance: 

| Spec  | input | Expected Output |
| :------------- | :------------- | :------------- |
| User input a word | hello | 8 |
| User input a sentence | hello world | 17 |
| User input a number | 12345 | Invalid Input |


## Links:

Github - https://github.com/weidai07/scrabble or https://github.com/misakimichy/Scrabble.Solution.git

## Setup/Installation Requirements:

1. Open https://github.com/weidai07/scrabble or https://github.com/misakimichy/Scrabble.Solution.git
2. Clone repository to local machine 
3. Build and Run project

  - $ dotnet build - when you are ready to build project
  - $ dotnet run - to run the project 
  - $ dotnet test - for testing the project
   

## Known Bugs

* _None at this time_

## Technologies Used:

* C#
* .NET
* MS Test

### License:

Copyright (c) 2019 Wei Dai and Misaki Koonce

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.