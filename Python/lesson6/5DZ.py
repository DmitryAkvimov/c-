# Русский алфавит с учётом буквы 'ё'
alphabet = 'абвгдеёжзийклмнопрстуфхцчшщъыьэюя'

# Ввод данных
message = input('Введите сообщение: ').lower()  # Приводим сообщение к нижнему регистру
shift = int(input('Введите сдвиг: '))

# Функция шифрования
def caesar_cipher(text, shift):
    encrypted_message = []
    for char in text:
        if char in alphabet:
            # Найдем индекс символа в алфавите и сдвинем его на shift
            new_index = (alphabet.index(char) + shift) % len(alphabet)
            encrypted_message.append(alphabet[new_index])
        else:
            # Если символ не в алфавите (пробел или знак препинания), просто добавляем его без изменений
            encrypted_message.append(char)
    
    # Объединяем список зашифрованных символов в строку
    return ''.join(encrypted_message)

# Вывод зашифрованного сообщения
encrypted_message = caesar_cipher(message, shift)
print('Зашифрованное сообщение:', encrypted_message)
