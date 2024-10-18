# Открываем файл и читаем строки
with open('zen.txt', 'r') as file:
    lines = file.readlines()

# Переворачиваем список строк
reversed_lines = reversed(lines)

# Выводим строки в обратном порядке
for line in reversed_lines:
    print(line.strip())  # strip() удаляет лишние пробелы и символы новой строки
