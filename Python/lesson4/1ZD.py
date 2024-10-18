# Определяем массивы
array_1 = [1, 5, 10, 20, 40, 80, 100]
array_2 = [6, 7, 20, 80, 100]
array_3 = [3, 4, 15, 20, 30, 70, 80, 120]

# Задача 1: найти элементы, которые есть в каждом списке

# Решение с использованием множеств
set_1 = set(array_1)
set_2 = set(array_2)
set_3 = set(array_3)

common_elements_with_sets = set_1 & set_2 & set_3
print(f"Решение с множествами (общие элементы): {sorted(common_elements_with_sets)}")

# Решение без использования множеств
common_elements_without_sets = []
for item in array_1:
    if item in array_2 and item in array_3:
        common_elements_without_sets.append(item)
print(f"Решение без множеств (общие элементы): {sorted(common_elements_without_sets)}")

# Задача 2: найти элементы из первого списка, которых нет во втором и третьем списках

# Решение с использованием множеств
difference_with_sets = set_1 - set_2 - set_3
print(f"Решение с множествами (разность): {sorted(difference_with_sets)}")

# Решение без использования множеств
difference_without_sets = []
for item in array_1:
    if item not in array_2 and item not in array_3:
        difference_without_sets.append(item)
print(f"Решение без множеств (разность): {sorted(difference_without_sets)}")
