def can_form_palindrome(s):
    # Словарь для подсчета количества каждого символа
    char_count = {}

    # Проходим по каждому символу строки и считаем их количество
    for char in s:
        char_count[char] = char_count.get(char, 0) + 1

    # Подсчитываем количество символов с нечетным количеством вхождений
    odd_count = 0
    for count in char_count.values():
        if count % 2 != 0:
            odd_count += 1

    # Если больше одного символа с нечетным количеством вхождений, то палиндром невозможен
    return odd_count <= 1

# Основная часть программы
input_str = input("Введите строку: ")

if can_form_palindrome(input_str):
    print("Можно сделать палиндромом")
else:
    print("Нельзя сделать палиндромом")
