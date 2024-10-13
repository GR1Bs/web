import json

phone_book = [
    {
        "имя": "Егор",
        "телефоны": [
            {
                "описание": "домашний",
                "номер": "123-456-7890"
            },
            {
                "описание": "рабочий",
                "номер": "987-654-3210"
            }
        ]
    },
    {
        "имя": "Екатерина",
        "телефоны": [
            {
                "описание": "мобильный",
                "номер": "555-123-4567"
            }
        ]
    }
]


with open('C:\\Users\\lesen\\OneDrive\\Рабочий стол\\phone_book.json.txt', "w") as file:
    json.dump(phone_book, file)

with open('C:\\Users\\lesen\\OneDrive\\Рабочий стол\\phone_book.json.txt', "r") as file:
    loaded_phone_book = json.load(file)


for entry in loaded_phone_book:
    print(f"Имя: {entry['имя']}")
    for phone_entry in entry['телефоны']:
        print(f"Телефон ({phone_entry['описание']}): {phone_entry['номер']}")
    print()
