import unittest
from Src.TheCalcStatsKata.CalcStat import process_minimum_value, \
    process_maximum_value, determine_number_of_elements_in_the_sequence, \
    determine_average_value_from_list, calc_stats


class CalcStatTests(unittest.TestCase):

    def test_should_return_the_minimum_value_from_list_with_negative(self):
        expected = -2
        list_of_numbers = [6, 9, 15, -2, 92, 11]
        actual = process_minimum_value(list_of_numbers)
        self.assertEqual(expected, actual)

    def test_should_return_the_minimum_value_from_list(self):
        expected = 1
        list_of_numbers = [6, 9, 15, 1, 92, 11]
        actual = process_minimum_value(list_of_numbers)
        self.assertEqual(expected, actual)

    def test_should_return_the_maximum_value_from_a_list(self):
        expected = 92
        list_of_numbers = [6, 9, 15, -2, 92, 11]
        actual = process_maximum_value(list_of_numbers)
        self.assertEqual(expected, actual)

    def test_should_return_the_maximum_value_from_a_list_of_negatives(self):
        expected = -2
        list_of_numbers = [-6, -105, -15, -2, -92, -11]
        actual = process_maximum_value(list_of_numbers)
        self.assertEqual(expected, actual)

    def test_should_return_the_number_of_elements_in_the_sequence(self):
        expected = 6
        list_of_numbers = [6, 9, 15, -2, 92, 11]
        actual = determine_number_of_elements_in_the_sequence(list_of_numbers)
        self.assertEqual(expected, actual)

    def test_should_return_the_number_of_elements_in_the_sequence_of_list_10(self):
        expected = 10
        list_of_numbers = [6, 9, 15, -2, 92, 11, 4, 14, 22, 106]
        actual = determine_number_of_elements_in_the_sequence(list_of_numbers)
        self.assertEqual(expected, actual)

    def test_should_return_the_average_value_from_given_list(self):
        expected = 21.833333333333332
        list_of_numbers = [6, 9, 15, -2, 92, 11]
        actual = determine_average_value_from_list(list_of_numbers)
        self.assertEqual(expected, actual)

    def test_should_return_the_min_max_count_and_average_from_given_list(self):
        expected_min = -2
        expected_max = 92
        expected_count = 6
        expected_average_value = 21.833333333333332
        expected = (expected_min, expected_max, expected_count, expected_average_value)
        list_of_numbers = [6, 9, 15, -2, 92, 11]
        actual = calc_stats(list_of_numbers)
        self.assertEqual(expected, actual)

    def test_should_return_the_min_max_count_and_average_from_given_list_of_8_values(self):
        expected_min = 1
        expected_max = 16
        expected_count = 8
        expected_average_value = 8.0
        expected = (expected_min, expected_max, expected_count, expected_average_value)
        list_of_numbers = [6, 9, 15, 1, 16, 11, 2, 4]
        actual = calc_stats(list_of_numbers)
        self.assertEqual(expected, actual)
