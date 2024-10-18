import pandas as pd

# Загрузка данных из файла advertising_1.csv с установкой индекса 'Number'
adv1_df = pd.read_csv('advertising_1.csv', index_col='Number')

# Вывод первых 10 строк
print(adv1_df.head(10))
