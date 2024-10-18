import pandas as pd
import seaborn as sns
import matplotlib.pyplot as plt

# Загрузка данных
df = pd.read_csv('data.csv')

# Проверка данных
print(df.info())  # Информация о типах данных и наличии пропусков
print(df.head())  # Просмотр первых строк данных

# Проверка и приведение данных к числовому формату (если необходимо)
df['age'] = pd.to_numeric(df['age'], errors='coerce')
df['spending_score'] = pd.to_numeric(df['spending_score'], errors='coerce')

# Удаление строк с пропущенными значениями (если есть)
df = df.dropna(subset=['age', 'spending_score'])

# Построение графика
sns.lineplot(x='age', y='spending_score', data=df)
plt.title('Age vs Spending Score')
plt.xlabel('Age')
plt.ylabel('Spending Score')

# Отображение графика
plt.show()
