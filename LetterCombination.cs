/*
Date: 18th June 2020
Question 1: Letter Combinations of a Phone Number
Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent.
A mapping of digit to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.

Example: 
Input: "23"
Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].

Solution Approach:
Approach 1:
Store the mapping of each number to char it represent in dictionary
Loop through each digit in input and add it to all strings
		Eg. List<string> letterComb;
for 2, take each char at a time and append it to all strings in letterComb.
So initially since it is an empty list. We will insert [a, b, c] into list
Then for 3, [a, b, c]-> [a, b, c]d, etc. => [ad, ae, af, bd, be, bf, cd, ce, cf]
Time Complexity = input (n) -> 3n/4n => O(n) 
Space requirement will be  = 2 list. O(3^n) + dictionary (constant).

Test cases:
“23”
“2489”
“25k”

*/

public class Solution {
    public IList<string> LetterCombinations(string digits) {
    List<string> letterComb = new List<string>();
    if(digits.Count()==0)
    {
        return letterComb ;
    }
    Dictionary<char, char[]> map = new Dictionary<char, char[]>{
        {'2', new char[]{'a', 'b', 'c'}},
        {'3', new char[]{'d', 'e', 'f'}},
        {'4', new char[]{'g', 'h', 'i'}},
        {'5', new char[]{'j', 'k', 'l'}},
        {'6', new char[]{'m', 'n', 'o'}},
        {'7', new char[]{'p', 'q', 'r', 's'}},
        {'8', new char[]{'t', 'u', 'v'}},
        {'9', new char[]{'w', 'x', 'y', 'z'}}
        };
    List<string> temp = new List<string>();
    letterComb.Add(string.Empty);
    foreach(char digit in digits)
    {
        temp = letterComb;
        letterComb = new List<string>();
        if(map.ContainsKey(digit))
        {
            char[] values = map[digit];
            foreach(string s in temp)
              {
                foreach(char valueC in values)
                {
                    letterComb.Add(s+valueC);
              }
            }
        }
        else
        {
            foreach(string s in temp)
              {
                    letterComb.Add(s+digit);
              }
        }
     }

      return letterComb;
    }
}
