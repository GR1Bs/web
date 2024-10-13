import pickle

def load_phonebook():
    
    try:
        with open('C:\\Users\\lesen\\OneDrive\\Рабочий стол\\phonebook.dat', 'rb') as file:
            return pickle.load(file)
    except (EOFError, FileNotFoundError):
        return []

def save_phonebook(phonebook):
    with open('C:\\Users\\lesen\\OneDrive\\Рабочий стол\\phonebook.dat', 'wb') as file:
        pickle.dump(phonebook, file)


def find_contacts_by_number(phonebook, number):
    found_contacts = []
    for contact in phonebook:
        for phone_entry in contact['телефоны']:
            if phone_entry['номер'] == number:
                found_contacts.append(contact)
                break
    return found_contacts

def find_contacts_by_name(phonebook, name):
    found_contacts = []
    for contact in phonebook:
        if contact['имя'] == name:
            found_contacts.append(contact)
    return found_contacts

def add_contact(phonebook, contact):
    phonebook.append(contact)
    save_phonebook(phonebook)


def delete_contact_by_name(phonebook, name):
    phonebook[:] = [contact for contact in phonebook if contact['имя'] != name]
    save_phonebook(phonebook)

def delete_phone_from_contact(phonebook, name, number):
    for contact in phonebook:
        if contact['имя'] == name:
            contact['телефоны'] = [entry for entry in contact['телефоны'] if entry['номер'] != number]
            save_phonebook(phonebook)
            break

phonebook = load_phonebook()

while True:
    print("\nМеню:")
    print("1. Поиск контактов по номеру телефона")
    print("2. Поиск контактов по имени")
    print("3. Добавить новый контакт")
    print("4. Удалить контакт по имени")
    print("5. Удалить номер телефона из контакта")
    print("6. Выйти")

    choice = input("Выберите действие (1/2/3/4/5/6): ")

    if choice == '1':
        number = input("Введите номер телефона для поиска: ")
        found_contacts = find_contacts_by_number(phonebook, number)
        if found_contacts:
            print("Найденные контакты:")
            for contact in found_contacts:
                print(f"Имя: {contact['имя']}")
        else:
            print("Контакты не найдены.")

    elif choice == '2':
        name = input("Введите имя для поиска: ")
        found_contacts = find_contacts_by_name(phonebook, name)
        if found_contacts:
            print("Найденные контакты:")
            for contact in found_contacts:
                print(f"Имя: {contact['имя']}")
        else:
            print("Контакты не найдены.")

    elif choice == '3':
        name = input("Введите имя нового контакта: ")
        phones = []
        while True:
            number = input("Введите номер телефона (или 'конец' для завершения): ")
            if number.lower() == '1':
                break
            description = input("Введите описание номера: ")
            phones.append({"номер": number, "описание": description})
        contact = {"имя": name, "телефоны": phones}
        add_contact(phonebook, contact)
        print("Контакт успешно добавлен.")

    elif choice == '4':
        name = input("Введите имя контакта для удаления: ")
        delete_contact_by_name(phonebook, name)
        print("Контакт удален.")

    elif choice == '5':
        name = input("Введите имя контакта, из которого нужно удалить номер: ")
        number = input("Введите номер телефона для удаления: ")
        delete_phone_from_contact(phonebook, name, number)
        print("Номер удален из контакта.")

    elif choice == '6':
        break

    else:
        print("Неверный выбор. Попробуйте еще раз.")

print("Выход из программы.")