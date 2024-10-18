from collections import Counter

def can_be_poly(val: str) -> bool:
    # Создаем счетчик частот символов в строке
    char_counts = Counter(val)
    # Проверяем количество символов с нечетным количеством вхождений
    odd_count = len(list(filter(lambda x: x % 2, char_counts.values())))
    # Условие для проверки возможности формирования палиндрома
    return odd_count < 2

# Запрос ввода строки у пользователя
user_input = input("Введите строку: ")
result = can_be_poly(user_input)
print(result)