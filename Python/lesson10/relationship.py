import pandas as pd
import seaborn as sns
import matplotlib.pyplot as plt

# Загрузка данных из CSV-файла
df = pd.read_csv('data.csv')

# Проверка на пропуски
print(df.isnull().sum())  # Проверка наличия пропусков

# Если есть пропуски, удалим строки с ними
df = df.dropna(subset=['salary', 'bonus', 'years_at_company'])

# Создание точечного графика
sns.scatterplot(x='salary', y='bonus', size='years_at_company', data=df, sizes=(20, 200))

# Настройка заголовка и меток осей
plt.title('Salary vs Bonus with Years at Company')
plt.xlabel('Salary')
plt.ylabel('Bonus')

# Отображение графика
plt.show()
