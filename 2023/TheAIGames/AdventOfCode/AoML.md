# Advent of Machine Learning

## Part 1:

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
## Part 2:

It turns out that there tend to be spaces in street names and it turns out that spaces cause quite a bit of issues when navigating. From now on, both the street names and the destination name can have multiple words!
When you come across a space in the destination name, all the logic for deciding if you should turn left or right is flipped from that point on, though be careful, when deciding if to turn right or left just before a space you will need to check the character after the space! Do be warned, this flipping can happen as many times as there are spaces! Spaces in the destination name are to be skipped when trying to match to a street name as they have no effect on the next street to turn on.
But the space mayhem does not stop here sadly! if there are spaces in the street names you are passing, you now need to check each word in the street name to see if it is the correct street to turn onto, thankfully this new logic turns out to be rather simple, all you need to do is check the current character at the index of the current word. if the first character of the first word matches the current character of the destination it is the correct street, if the second character of the second word matches it is the correct street and so on! If the word is shorter than the index then you simply wrap around to the start of the word! Lets see a quick example!

#### Example:
Inputs:
```
Frank St
Strangers but not things
Hogwarts yfere st
Rango st
Bamboo Timboo Limboo
Haberham abraham traberham
Abraham
Run
Quickly Flip
Marek Counts
Hanagans National fast Fran
Willow st
Krill Nation road
Fran Lake drive
Strange Thing st
Bamboo Timboo Limboo
Redo st
```
Output:
```
1R
0L
1R
4L
1R
1L
1D
```

## Part 3:

It turns out that New York city blocks are HUGE and people now want you to drop them off at specific addresses instead of the block corners! When will their demands stop! Thankfully this new logic is equally as simple as the previous steps to get your autonomous car dropping people off at the right place. The destination address now has two parts, the first part is the building number and the second part is the street name. The building number is a single number that can get as large as 99999 and the street name is the rest of the first line. There are no numbers in the street name.

Each of the new digits in the destination address affect your directions in two ways. As you itterate over the characters in the street name of the destination, so too should you iterate over the digits in the building number. Each time you come across a digit in the building number you should skip that many streets before checking if the next street name is the correct street to turn onto. If the building number is shorter than the street name you should wrap around to the start of the building number. 

Not only does this digit cause you to skip that many streets before looking for the destination street, but it also effects the indexing of your character search, initially if it was the second word you would check the character in the second spot, but if the building number was 2 you would check the character in the 4th spot! If the word happens to be shorter then the index you should wrap around to the start of the word as usual!

#### Note:
The street name can have spaces in it, but the building number can not! Also, the subsequent list of street names does not have a building number, just the street name so the only thing changing in the list is the destination address!

#### Example:
Inputs:
```
2 Bob st
Blammy st.
Based road
Basement bar st
Oh the pain lane
Krab are real st
Never Bo lane
Frightened Kitten St
Please save us road
Neverbefore seen cba road
Fill
fill
Sonic outpost lane
Fill
fill
Gin and Tonic
```
Output:
```
3R
2L
2R
0L
0D
```
