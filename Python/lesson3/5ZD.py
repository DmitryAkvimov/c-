# Ввод количества заказов
n = int(input("Введите количество заказов: "))
orders = {}

# Обработка каждого заказа
for i in range(n):
    order = input(f"{i + 1}-й заказ: ")
    buyer, pizza, quantity = order.split()
    quantity = int(quantity)  # Преобразуем количество в целое число

    # Если покупатель еще не существует, добавляем его в словарь
    if buyer not in orders:
        orders[buyer] = {}
    
    # Если пицца уже есть в заказах покупателя, увеличиваем количество
    if pizza in orders[buyer]:
        orders[buyer][pizza] += quantity
    else:
        # Если пиццы нет, добавляем ее в словарь
        orders[buyer][pizza] = quantity

# Сортируем покупателей по алфавиту и выводим результаты
for buyer in sorted(orders):
    print(f"{buyer}:")
    for pizza in sorted(orders[buyer]):
        print(f"{pizza}: {orders[buyer][pizza]}")
