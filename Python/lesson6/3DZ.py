# Генерация двумерного списка с помощью list comprehension
result = [[i, i + 4, i + 8] for i in range(1, 5)]

# Вывод результата
for row in result:
    print(row)
