def count_unique_characters(string: str) -> int:
    # Приводим строку к нижнему регистру, чтобы сделать подсчет регистронезависимым
    lower_string = string.lower()
    # Используем filter для выбора символов, которые встречаются в строке ровно один раз
    unique_chars = list(filter(lambda c: lower_string.count(c) == 1, lower_string))
    # Возвращаем количество уникальных символов
    return len(unique_chars)

# Запрос ввода строки у пользователя
user_input = input("Введите строку: ")
unique_count = count_unique_characters(user_input)
print("Количество уникальных символов в строке:", unique_count)
