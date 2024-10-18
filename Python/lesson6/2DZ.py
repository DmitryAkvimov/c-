import random

# Генерация двух команд из 20 участников с очками в диапазоне от 5 до 10
first_team = [round(random.uniform(5, 10), 2) for _ in range(20)]
second_team = [round(random.uniform(5, 10), 2) for _ in range(20)]

# Создание списка победителей, где выбирается максимальное значение между соответствующими участниками
winners = [max(first_team[i], second_team[i]) for i in range(20)]

# Вывод результатов
print("Первая команда:", first_team)
print("Вторая команда:", second_team)
print("Победители тура:", winners)
