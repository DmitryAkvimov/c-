# Инициализация счетчиков
positive_count = 0
negative_count = 0

# Запуск цикла while
while True:
    rating = int(input("Введите число: "))  # Ввод числа

    if rating == 0:  # Если введено 0, завершаем цикл
        break

    if rating > 0:  # Если число положительное
        positive_count += 1
    elif rating < 0:  # Если число отрицательное
        negative_count += 1

# Вывод результата
print(f"Кол-во положительных чисел: {positive_count}")
print(f"Кол-во отрицательных чисел: {negative_count}")
