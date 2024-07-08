employee_id = [10, 20, 30, 40, 50]

for i, element in enumerate(employee_id):
    print(f"Element at index {i}: {element}")

print("Element at index 2:", employee_id[2])

employee_id[1] = 25
print("Modified array:", employee_id)

employee_id.append(60)
print("Array after appending:", employee_id)

employee_id.insert(2, 35)
print("hiring employee:", employee_id)

employee_id.remove(40)
print("fire employee:", employee_id)

print("Length id:", len(employee_id))