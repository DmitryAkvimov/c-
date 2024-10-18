import copy

# Исходная структура сайта
site_template = {
    'html': {
        'head': {
            'title': 'Куплю/продам телефон недорого'
        },
        'body': {
            'h2': 'У нас самая низкая цена на iPhone',
            'div': 'Купить',
            'p': 'Продать'
        }
    }
}

# Функция для замены значений по ключам 'title' и 'h2'
def change_value(struct, product_name):
    for key, value in struct.items():
        if isinstance(value, dict):
            change_value(value, product_name)
        else:
            if key == 'title':
                struct[key] = f'Куплю/продам {product_name} недорого'
            elif key == 'h2':
                struct[key] = f'У нас самая низкая цена на {product_name}'

# Функция для создания сайта
def make_site(product_name):
    # Глубокое копирование шаблона сайта
    new_site = copy.deepcopy(site_template)
    # Изменяем значения на основе названия продукта
    change_value(new_site, product_name)
    return new_site

# Функция для отображения структуры сайта
def display_struct(struct, spaces=0):
    for key, value in struct.items():
        if isinstance(value, dict):
            print(' ' * spaces + f"'{key}': {{")
            display_struct(value, spaces + 4)
            print(' ' * spaces + '}')
        else:
            print(' ' * spaces + f"'{key}': '{value}'")

# Основная программа
def main():
    sites = []
    sites_count = int(input("Сколько сайтов: "))
    
    for i in range(sites_count):
        product_name = input("Введите название продукта для нового сайта: ")
        new_site = make_site(product_name)
        sites.append(new_site)
        
        # Отображаем все созданные сайты
        for idx, site in enumerate(sites):
            print(f"\nСайт для {product_name if idx == len(sites) - 1 else 'предыдущих продуктов'}:")
            print('site = {')
            display_struct(site, 4)
            print('}')

# Запуск программы
main()
