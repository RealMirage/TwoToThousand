# TwoToThousand
A small C# program that calculates 2 to the 1000th power (2**1000).
The numbers of each product are stored in an array in reverse order of their notation


      e.g. 250 = [0,5,2]
Each element is then doubled and remainders are transferred to elements to the right so that no single element exceeds 9


      e.g. 128 = [8,2,1]
           256 = 128 * 2 = [8 * 2, 2 * 2, 1 * 2] =  [16,4,2] = [16 - 10, 4 + 1, 2] = [6,5,2]
This is iterated until reaching the desired power.       
 
