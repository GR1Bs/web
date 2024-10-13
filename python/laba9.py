
file_path = 'C:\\Users\\lesen\\OneDrive\\Рабочий стол\\Текстовый документ.txt'

with open(file_path, 'r') as file:
    content = file.read()

space_index = content.find(' ')

if space_index != -1:
    new_content = content[space_index + 1:]
else:
    new_content = content

with open( 'C:\\Users\\lesen\\OneDrive\\Рабочий стол\\Текстовый документ.txt', 'w') as file:
    file.write(new_content)
