# Функция для выдления из строки текста целых цифр
def CodeTextClearing ():
    # Ввод любого текста
    InputUserString = str(input('Введите любой текст:'))
    StringOfDigits = str()
    Result = []

    # Ряд символов для сравнения с символами в тексте
    Nums = ['1','2','3','4','5','6','7','8','9','0']
    
    # Цикл создания массива состоящего из цифр
    for i in range(len(InputUserString)):
        if InputUserString[i] in Nums:
            StringOfDigits += InputUserString[i]
        elif InputUserString[i] == '-':
            StringOfDigits += ','+InputUserString[i]
        else:
            StringOfDigits +=','
    StringClearing = list(((i) for i in StringOfDigits.split(',') ))
    # Цикл очистки массива
    for i in range(len(StringClearing)):
        if StringClearing[i] == '':
            i+=1
        elif StringClearing[i] == '-':
            i+=1
        else:
            StringClearing[i] = int(StringClearing[i])
            Result.append(StringClearing[i])

    return (Result)
Result = CodeTextClearing()
# Выод данных 
print('Все целые числа в ряду: ', *Result, '\n', 
'Положительные числа в ряду: ', *([i for i in Result if i>0]), '\n',
'Положительных чисел в тексте: ', len([i for i in Result if i>0]))
