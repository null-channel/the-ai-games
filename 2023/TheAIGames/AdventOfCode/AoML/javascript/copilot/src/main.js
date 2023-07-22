/*
You are a new taxi cab driver in New york city, the only problem is that you have never driven in New York city before! It’s quite a long story how you got into this position but needless to say you need to make it work. It turns out just last week one of the veterans of the industry retired and left you a message… Driving a taxi cab was easy! You find out that your taxi cab actually drives itself! All you have to do is translate the directions for your taxi cab! Because it’s New York city the directions are given in the form of a list of street names, each item in the list is on a new line. The destination address, the place you are trying to get your cab to drive to is the very first word in the list. We will refer to this as the destination from now on. For each letter in the destination, all you have to do is find the next street in the remaining list that starts with that letter and count the number of street names you had to pass over to get to it! Deciding if you should turn right or left on this street is as simple as calculating the numerical value of the current character you are using from the destination and the character that comes directly after. If the current character is larger, turn left, if the subsequent character is larger then turn right!
Sadly your self driving car was designed before yaml and takes an unstructured list of directions so your application needs to output a sequential order of steps. Each step should be on a newline, Each line should start with the number of streets to pass and a character of ether R for right, L for left and D for when you reach your destination.
When you come to the last character in the address your destination will be on the corner of the next street that starts with the last character! 
That's it! Here is an example of the inputs you will get and the resulting output! Your goal is to print directions to the destination in terms of how many streets to skip and the direction to turn so that your car can drive itself!

#### Example:
Inputs:
```
Dan
Asdf
Bard
Fdsa
Daisy
Nand
Andrew
Band
Ned
Follow
```
Output:
```
3L
1R
1D
```
*/

// Path: src/main.js
/*
You are a new taxi cab driver in New york city, the only problem is that you have never driven in New York city before! It’s quite a long story how you got into this position but needless to say you need to make it work. It turns out just last week one of the veterans of the industry retired and left you a message… Driving a taxi cab was easy! You find out that your taxi cab actually drives itself! All you have to do is translate the directions for your taxi cab! Because it’s New York city the directions are given in the form of a list of street names, each item in the list is on a new line. The destination address, the place you are trying to get your cab to drive to is the very first word in the list. We will refer to this as the destination from now on. For each letter in the destination, all you have to do is find the next street in the remaining list that starts with that letter and count the number of street names you had to pass over to get to it! Deciding if you should turn right or left on this street is as simple as calculating the numerical value of the current character you are using from the destination and the character that comes directly after. If the current character is larger, turn left, if the subsequent character is larger then turn right!
Sadly your self driving car was designed before yaml and takes an unstructured list of directions so your application needs to output a sequential order of steps. Each step should be on a newline, Each line should start with the number of streets to pass and a character of ether R for right, L for left and D for when you reach your destination.
When you come to the last character in the address your destination will be on the corner of the next street that starts with the last character!
That's it! Here is an example of the inputs you will get and the resulting output! Your goal is to print directions to the destination in terms of how many streets to skip and the direction to turn so that your car can drive itself!

#### Example:
Inputs:
```
Dan
Asdf
Bard
Fdsa
Daisy
Nand
Andrew
Band
Ned
Follow
```
Output:
```
3L
1R
1D
```
*/

// Path: src/main.js
/*

