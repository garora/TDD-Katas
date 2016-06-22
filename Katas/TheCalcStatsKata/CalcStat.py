"""
Your task is to process a sequence of integer numbers
to determine the following statistics:

    o) minimum value
    o) maximum value
    o) number of elements in the sequence
    o) average value

For example: [6, 9, 15, -2, 92, 11]

    o) minimum value = -2
    o) maximum value = 92
    o) number of elements in the sequence = 6
    o) average value = 18.166666

"""


def process_minimum_value(value_list):
    # Could sort the list and grab the first value
    # Could also use the min function
    minimum = None
    for value in value_list:
        if not minimum or value < minimum:
            minimum = value
    return minimum


def process_maximum_value(value_list):
    # Could sort the list and grab the last value
    # Could also use the max function
    maximum = None
    for value in value_list:
        if not maximum or value > maximum:
            maximum = value
    return maximum


def determine_number_of_elements_in_the_sequence(value_list):
    # Attempt 1 - Works
    # count = 0
    # for value in value_list:
    #     count += 1
    # return count

    # Attempt 2 - Less code
    return len(value_list)


def determine_average_value_from_list(value_list):
    total = 0.0
    for value in value_list:
        total += value
    average_value = total/float(len(value_list))
    return average_value


def calc_stats(value_list):
    minimum = process_minimum_value(value_list)
    maximum = process_maximum_value(value_list)
    count = determine_number_of_elements_in_the_sequence(value_list)
    average_value = determine_average_value_from_list(value_list)
    return minimum, maximum, count, average_value
