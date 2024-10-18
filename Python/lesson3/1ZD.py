# Ввод количества видеокарт
n = int(input("Введите количество видеокарт: "))

# Инициализация списка для видеокарт
video_cards = []

# Ввод данных о видеокартах
for i in range(n):
    card = int(input(f"Видеокарта {i + 1}: "))
    video_cards.append(card)

# Определение максимального значения в списке видеокарт
max_card = max(video_cards)

# Формирование нового списка без наибольших значений
new_video_cards = [card for card in video_cards if card != max_card]

# Вывод старого списка видеокарт
print("Старый список видеокарт:", video_cards)

# Вывод нового списка видеокарт
print("Новый список видеокарт:", new_video_cards)
