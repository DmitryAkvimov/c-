from functools import reduce

# Исходные списки
floats = [12.3554, 4.02, 5.777, 2.12, 3.13, 4.44, 11.0001]
names = ["Юля", "Алик", "Жанна", "Виктор", "Рома", "Женя"]
numbers = [22, 33, 10, 6894, 11, 2, 1]

# 1. Возведение в третью степень и округление до 3 знаков
new_floats = list(map(lambda x: round(pow(x, 3), 3), floats))

# 2. Фильтрация имен с длиной 5 или больше символов
new_names = list(filter(lambda name: len(name) >= 5, names))

# 3. Произведение всех чисел в списке
product_of_numbers = reduce(lambda x, y: x * y, numbers)

# Вывод результатов
print("Floats (в третьей степени):", new_floats)
print("Names (больше 4 букв):", new_names)
print("Произведение всех чисел:", product_of_numbers)
