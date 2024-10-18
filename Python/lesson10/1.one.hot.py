import pandas as pd
import random

# Генерация DataFrame
lst = ['robot'] * 10
lst += ['human'] * 10
random.shuffle(lst)
data = pd.DataFrame({'whoAmI': lst})

# Получаем уникальные значения столбца 'whoAmI'
unique_values = data['whoAmI'].unique()

# Создаем пустой DataFrame для one-hot кодирования
one_hot = pd.DataFrame()

# Для каждого уникального значения создаем бинарный столбец
for value in unique_values:
    one_hot[value] = (data['whoAmI'] == value).astype(int)

# Объединяем DataFrame с one-hot кодированием с исходным DataFrame
data = pd.concat([data, one_hot], axis=1)

# Выводим результат
print(data.head())
