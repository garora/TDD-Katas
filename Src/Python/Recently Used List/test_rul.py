import unittest
from rul import RecentlyUsedList

class RecentlyUsedListTests(unittest.TestCase):
    def test_creating_a_new_list(self):
        rul = RecentlyUsedList()
        self.assertEqual(len(rul), 0)

    def test_inserting_an_item(self):
        rul = RecentlyUsedList()
        item = 'item'
        rul.insert(item)
        self.assertEqual(len(rul), 1)
        self.assertEqual(rul[0], item)

    def test_inserting_two_unique_items(self):
        rul = RecentlyUsedList()
        rul.insert('first')
        most_recent_item = 'second'
        rul.insert(most_recent_item)
        self.assertEqual(rul[0], most_recent_item)

    def test_inserting_a_duplicate(self):
        rul = RecentlyUsedList()
        duplicate = 'b'
        for item in 'a', duplicate, 'c', duplicate:
            rul.insert(item)
        self.assertEqual(len(rul), 3)
        self.assertEqual(rul[0], duplicate)
