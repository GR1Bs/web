 
matrix = [
    [5, 2, 8],
    [7, 1, 4],
    [3, 9, 6]
]

order =len(matrix)
max_in_row=[max(row) for row in matrix]
min_in=[min(matrix[i][j] for i in range(order))for j in range(order)]
print("Наибольший элемент в каждой строке")
print(max_in_row)
print("Наименший элемент в каждом столбце")
print (min_in)