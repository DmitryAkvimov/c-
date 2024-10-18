# Открываем входной файл numbers.txt для чтения
with open('numbers.txt', 'r') as file:
    # Читаем все содержимое файла, разделяем по пробелам и символам новой строки
    numbers = file.read().split()

# Преобразуем каждую часть в целое число и суммируем
total_sum = sum(int(number) for number in numbers)

# Открываем выходной файл answer.txt для записи результата
with open('answer.txt', 'w') as file:
    file.write(str(total_sum))  # Записываем сумму в файл
