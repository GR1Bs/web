from datetime import datetime
birthdate = input("Введите дату рождения (год-месяц-день): ")

birth_datetime = datetime.strptime(birthdate, "%Y-%m-%d")

current_datetime = datetime.now()

time_difference = current_datetime - birth_datetime

total_seconds = time_difference.total_seconds()
total_minutes = total_seconds / 60
total_hours = total_minutes / 60
print(f"Всего прожито: {total_seconds:.0f} секунд, {total_minutes:.0f} минут, {total_hours:.2f} часов.")