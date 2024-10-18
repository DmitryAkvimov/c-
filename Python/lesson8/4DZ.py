import string

# Чтение данных из файла text.txt
with open('text.txt', 'r') as file:
    text = file.read().lower()

# Инициализация словаря для подсчета количества каждой буквы
letter_counts = {letter: 0 for letter in string.ascii_lowercase}

# Подсчет количества каждой буквы и общего количества букв
total_letters = 0
for char in text:
    if char in letter_counts:
        letter_counts[char] += 1
        total_letters += 1

# Формирование словаря для долей букв
letter_frequencies = {}
for letter, count in letter_counts.items():
    if count > 0:
        letter_frequencies[letter] = count / total_letters

# Сортировка букв по убыванию доли, а при равенстве по алфавиту
sorted_letters = sorted(letter_frequencies.items(), key=lambda x: (-x[1], x[0]))

# Запись результатов в файл analysis.txt
with open('analysis.txt', 'w') as file:
    for letter, freq in sorted_letters:
        file.write(f"{letter} {freq:.3f}\n")
