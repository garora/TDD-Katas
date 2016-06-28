import string

__author__ = 'smelnyk'

# http://codingdojo.org/cgi-bin/index.pl?KataRomanNumerals
# http://www.roman-numerals.org/chart100.html
# http://www.novaroma.org/via_romana/numbers.html
# http://www.roman-numerals.org/calculator.html


def get_roman_numeral(number):
    """
    Return the Roman Numeral represented by the number specified
    """
    # e.g. 5 -> "V", 1 -> "I"

    #print "Original number is: %s" % number

    numeral = ''

    if number <= 0:
        raise TypeError("The number you entered is invalid: {num} is not a positive integer.".format(num=number))

    if not isinstance(number, (int, long)):
        raise TypeError("The value you entered is invalid: {num} is not a positive integer.".format(num=number))

    while number >= 1000:
        numeral += 'M'
        number -= 1000

    if number >= 900 and number < 1000:
        numeral += 'CM'
        number -= 900

    while number >= 500:
        numeral += 'D'
        number -= 500

    if number >= 400 and number < 500:
        numeral += 'CD'
        number -= 400

    while number >= 100:
        numeral += 'C'
        number -= 100

    if number >= 90 and number < 100:
        numeral += 'XC'
        number -= 90

    while number >= 50:
        numeral += 'L'
        number -= 50

    if number >= 40 and number < 50:
        numeral += 'XL'
        number -= 40

    while number >= 10:
        numeral += 'X'
        number -= 10

    if number == 9:
        numeral += 'IX'
        number -= 9

    if number >= 5:
        numeral += 'V'
        number -= 5

    if number == 4:
        numeral += 'IV'
        number -= 4

    while number >= 1:
        numeral += 'I'
        number -= 1

    #print "Numeral String is: %s." % numeral
    return numeral


def get_number_from_roman_numeral(numeral):
    """
    Return the number represented by the single numeral
    """
    # e.g. "V" -> 5, "I" -> 1
    # TODO: Will need to consider the lowercase of these characters as well
    # 1 = I, i
    # 4 = IV, iv
    # 5 = V, v
    # 9 = IX, ix
    # 10 = X, x
    # 40 = XL, xl
    # 50 = L, l
    # 90 = XC, xc
    # 100 = C, c
    # 400 = CD, cd
    # 500 = D, d
    # 900 = CM, cm
    # 1000 = M, m

    # check if the "I" is followed by another "I", if so - add 1 and continue as normal
    # if not - "I" will subtract 1 and then it'll add and continue as normal
    # IV = -1 + 5 = 4
    # IX = -1 + 10 = 9


    numeral = string.upper()

    Roman_Value_Map = {'I': 1, 'V': 5, 'X': 10, 'L': 50, 'C': 100, 'D': 500, 'M': 1000}
    number = 0

    numeral_split = list(numeral)
    first_roman = numeral_split[0]
    second_roman = numeral_split[1]

    print numeral_split
    print first_roman
    print second_roman

    if first_roman == second_roman:
        for roman_letter in numeral_split:
            if roman_letter == 'L':
                number += 50
            elif roman_letter == 'X':
                number += 10
            elif roman_letter == 'V':
                number += 5
            else:
                number += 1
    else:
        for roman_letter in numeral_split:
            if roman_letter == ['I'] and ['X']:
                number += 9
            elif roman_letter == ['I'] and ['V']:
                number += 4

    print number
    return number