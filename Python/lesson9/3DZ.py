import pandas as pd  # Добавляем импорт библиотеки pandas

# Загрузка данных из файла advertising_2.csv с установкой столбца 'Number' как индекса
adv2_df = pd.read_csv('advertising_2.csv', index_col='Number')

# Вывод строк для пользователей с номерами с 533-го по 536-й
users_533_to_536 = adv2_df.loc[533:536]
print(users_533_to_536)
