from typing import List, Tuple

# Исходные списки
letters: List[str] = ['a', 'b', 'c', 'd', 'e']
numbers: List[int] = [1, 2, 3, 4, 5]

# Создание списка кортежей, состоящих из пар элементов из обоих списков
results: List[Tuple[str, int]] = [ (letters[i], numbers[i]) for i in range(min(len(letters), len(numbers))) ]

# Вывод результатов
print(results)
