# Чтение данных из файла first_tour.txt
with open('first_tour.txt', 'r') as file:
    lines = file.readlines()

# Извлечение порога K
K = int(lines[0].strip())

# Список для участников второго тура
participants = []

# Обработка данных участников
for line in lines[1:]:
    surname, name, score = line.split()  # Разделение строки на фамилию, имя и баллы
    score = int(score)  # Преобразование баллов в целое число
    
    # Если баллы больше порога, добавляем в список участников второго тура
    if score > K:
        participants.append((score, surname, name[0]))  # Сохраняем баллы, фамилию и первую букву имени

# Сортируем участников по количеству баллов в порядке убывания
participants.sort(reverse=True, key=lambda x: x[0])

# Запись результатов во второй тур в файл second_tour.txt
with open('second_tour.txt', 'w') as file:
    # Записываем количество участников второго тура
    file.write(f"{len(participants)}\n")
    
    # Записываем каждого участника в формате "номер) И. Фамилия Баллы"
    for idx, (score, surname, initial) in enumerate(participants, start=1):
        file.write(f"{idx}) {initial}. {surname} {score}\n")
