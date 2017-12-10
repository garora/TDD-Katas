class RecentlyUsedList:
    def __init__(self):
        self._list = []

    def __len__(self):
        return len(self._list)

    def insert(self, item):
        try:
            self._list.remove(item)
        except ValueError:
            pass
        self._list.insert(0, item)

    def __getitem__(self, index):
        return self._list[index]
