# Ваша квадратная матрица
matrix = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
]

# Находим размер матрицы
size = len(matrix)

# Находим индексы максимальных элементов на главной и побочной диагоналях
main_diag_index = [i for i in range(size) if matrix[i][i] == max(matrix[i][i] for i in range(size))][0]
side_diag_index = [i for i in range(size) if matrix[i][size - 1 - i] == max(matrix[i][size - 1 - i] for i in range(size))][0]

# Меняем местами максимальные элементы
matrix[main_diag_index][main_diag_index], matrix[main_diag_index][size - 1 - main_diag_index] = \
    matrix[main_diag_index][size - 1 - main_diag_index], matrix[main_diag_index][main_diag_index]


for row in matrix:
    print(row)
