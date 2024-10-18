def find_key(struct, key, max_depth=None, depth=1):
    # Если максимальная глубина задана и текущая глубина превышает её, прекращаем поиск
    if max_depth is not None and depth > max_depth:
        return None

    # Проверяем, есть ли ключ в текущем словаре
    if key in struct:
        return struct[key]

    # Если ключа нет, то проходим по всем элементам словаря
    for value in struct.values():
        if isinstance(value, dict):  # Если значение — это словарь, ищем в нём
            result = find_key(value, key, max_depth, depth + 1)
            if result is not None:
                return result

    # Если ключ не найден, возвращаем None
    return None

# Основная программа
site = {
    'html': {
        'head': {
            'title': 'Мой сайт'
        },
        'body': {
            'h2': 'Здесь будет мой заголовок',
            'div': 'Тут, наверное, какой-то блок',
            'p': 'А вот здесь новый абзац'
        }
    }
}

# Получаем данные от пользователя
key = input("Введите искомый ключ: ")
use_max_depth = input("Хотите ввести максимальную глубину? Y/N: ").lower()

if use_max_depth == 'y':
    max_depth = int(input("Введите максимальную глубину: "))
else:
    max_depth = None

# Ищем ключ
value = find_key(site, key, max_depth)

# Выводим результат
if value is not None:
    print(f"Значение ключа: {value}")
else:
    print("Ключ не найден.")