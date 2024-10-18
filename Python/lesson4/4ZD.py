def create_frequency_dict(text):
    frequency_dict = {}
    for char in text:
        # Используем метод get() для увеличения частоты или добавления нового символа
        frequency_dict[char] = frequency_dict.get(char, 0) + 1
    return frequency_dict

def invert_frequency_dict(frequency_dict):
    inverted_dict = {}
    for char, freq in frequency_dict.items():
        if freq not in inverted_dict:
            inverted_dict[freq] = []
        inverted_dict[freq].append(char)
    return inverted_dict

def print_sorted_dict(d):
    for key in sorted(d):
        print(f"{key}: {d[key]}")

# Основная программа
text = input("Введите текст: ")

# Создаем оригинальный словарь частот
frequency_dict = create_frequency_dict(text)
print("Оригинальный словарь частот:")
print_sorted_dict(frequency_dict)

# Создаем инвертированный словарь частот
inverted_dict = invert_frequency_dict(frequency_dict)
print("\nИнвертированный словарь частот:")
print_sorted_dict(inverted_dict)
