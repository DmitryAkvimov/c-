# Данные о товарах
goods = {
    'Лампа': '12345',
    'Стол': '23456',
    'Диван': '34567',
    'Стул': '45678',
}

store = {
    '12345': [
        {'quantity': 27, 'price': 42},
    ],
    '23456': [
        {'quantity': 22, 'price': 510},
        {'quantity': 32, 'price': 520},
    ],
    '34567': [
        {'quantity': 2, 'price': 1200},
        {'quantity': 1, 'price': 1150},
    ],
    '45678': [
        {'quantity': 50, 'price': 100},
        {'quantity': 12, 'price': 95},
        {'quantity': 43, 'price': 97},
    ],
}

# Проход по каждому товару
for item_name, item_code in goods.items():
    total_quantity = 0  # Общее количество товара
    total_cost = 0      # Общая стоимость товара

    # Проход по всем записям для данного кода товара
    for record in store[item_code]:
        total_quantity += record['quantity']  # Суммируем количество
        total_cost += record['quantity'] * record['price']  # Считаем стоимость

    # Вывод информации о товаре
    print(f"{item_name} — {total_quantity} штук, стоимость {total_cost} рублей.")
