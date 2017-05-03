'''
You are given a string s. It consists of alphanumeric characters, spaces and symbols. 
Your task is to find all the substrings of s that contains 2 or more vowels. 
Also, these substrings must lie in between 2 consonants and should contain vowels only.
'''
import re
vowels = 'AEIOUaeiou' # it's slower to rely on the ri.I flag instead, but practically it does not matter
consonants= 'QWRTYPSDFGHJKLZXCVBNMqwrtypsdfghjklzxcvbnm'
matches = re.findall(r'(?<=['+consonants+'])(['+vowels+']{2,})(?=['+consonants+'])',input())#,flags = re.I)
if len(matches) < 1:
    print("-1")
else:
    [print(match) for match in matches]