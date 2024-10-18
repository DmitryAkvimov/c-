import pandas as pd  # Импорт библиотеки pandas

# Загрузка данных из файла advertising_1.csv с установкой столбца 'Number' как индекса
adv1_df = pd.read_csv('advertising_1.csv', index_col='Number')

# Вывод размера датафрейма
print("Размер датафрейма:", adv1_df.shape)

# Вывод среднего ежедневного времени нахождения в интернете пользователя под номером 8
daily_internet_usage_user_8 = adv1_df.loc[8, 'Daily Internet Usage']
print("Среднее время нахождения в интернете для пользователя 8:", daily_internet_usage_user_8)
