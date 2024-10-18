import zipfile
import string
from collections import defaultdict

# Распаковка архива и чтение файла
with zipfile.ZipFile('voina-i-mir.zip', 'r') as archive:
    # Получаем список файлов в архиве
    file_list = archive.namelist()
    
    # Находим текстовый файл
    for file_name in file_list:
        if file_name.endswith('.txt'):
            with archive.open(file_name) as file:
                # Чтение файла и декодирование в строку
                text = file.read().decode('utf-8')

# Инициализация словаря для подсчета количества каждой буквы
letter_counts = defaultdict(int)

# Подсчёт букв в тексте
for char in text:
    if char.isalpha():  # Учитываем только буквы
        letter_counts[char] += 1

# Сортировка по убыванию частоты, при равенстве - по символу
sorted_letters = sorted(letter_counts.items(), key=lambda x: (-x[1], x[0]))

# Выводим результат
for letter, count in sorted_letters:
    print(f'{letter}: {count}')
