# -*- coding: utf-8 -*-
"""
Created on Fri May 26 00:40:59 2017

@author: fgrimps
"""

#Q: In a single toss of 2 fair six-sided dice, find the probability that the 
#values rolled by each die will be different and the two dice have a sum of 6.

#A: We have 36 possibilities with two dice.
#There are 4 cases that match the desired criteria: (1,5) (5,1) (2,4) (4,2)
#Thus, the probability for this event is 4/36 => 1/9

import itertools
from fractions import Fraction

die1 = [1, 2, 3, 4, 5, 6]
die2 = [1, 2, 3, 4, 5, 6]

cartesian_product = [element for element in itertools.product(die1, die2)]
cp_values_different = [cp for cp in cartesian_product if cp[0] != cp[1]]
elements_have_sum_six = [cp for cp in cp_values_different if cp[0] + cp[1] == 6]

number_favorable_outcomes = len(elements_have_sum_six)
total_outcomes = len(cartesian_product)

print(Fraction(number_favorable_outcomes, total_outcomes))