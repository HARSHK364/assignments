try:

    x = 5 / 0

except ZeroDivisionError:

   print("Error: Cannot divide by zero!")

except Exception as e:
    print("An error occurred:", str(e))

finally:
    print("this is how division takes place")
