def create_synonym_dict():
    # Ввод количества пар синонимов
    n = int(input("Введите количество пар слов: "))
    synonym_dict = {}

    # Заполнение словаря синонимов
    for i in range(n):
        pair = input(f"Пара {i + 1}: ").strip().lower()
        word_1, word_2 = pair.split(' — ')
        synonym_dict[word_1] = word_2
        synonym_dict[word_2] = word_1

    return synonym_dict

def find_synonym(synonym_dict):
    while True:
        word = input("Введите слово: ").strip().lower()
        if word in synonym_dict:
            print(f"Синоним: {synonym_dict[word]}")
            break
        else:
            print("Такого слова в словаре нет. Попробуйте снова.")

# Основная часть программы
synonym_dict = create_synonym_dict()
find_synonym(synonym_dict)
