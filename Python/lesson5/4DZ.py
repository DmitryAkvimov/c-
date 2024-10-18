def flatten(a_list):
    result = []  # Создаем пустой список для хранения результата
    
    for element in a_list:  # Проходим по всем элементам входного списка
        if isinstance(element, int):  # Если элемент — целое число, добавляем его в результат
            result.append(element)
        elif isinstance(element, list):  # Если элемент — список, рекурсивно вызываем flatten
            result.extend(flatten(element))  # Добавляем элементы вложенного списка в результат
    
    return result  # Возвращаем результирующий список

# Пример использования
nice_list = [1, 2, [3, 4], [[5, 6, 7], [8, 9, 10]], [[11, 12, 13], [14, 15], [16, 17, 18]]]
flattened_list = flatten(nice_list)
print(flattened_list)  # Ожидаемый вывод: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18]
