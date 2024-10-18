nice_list = [[[1, 2, 3], [4, 5, 6], [7, 8, 9]], [[10, 11, 12], [13, 14, 15], [16, 17, 18]]]

# Генерация плоского списка с помощью вложенных list comprehensions
flat_list = [digit for each_list in nice_list for each_sublist in each_list for digit in each_sublist]

# Вывод результата
print(flat_list)
