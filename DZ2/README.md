# Домашнее задание № 2
## Описание задачи:
**_Написать программу_, которая из имеющегося массива _целых чисел_ формирует массив из _чисел больших 8_. Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.**
## Решение
### Для решения использованы следующие методы:
* FillArray
* ShowCollection
* LargeValueCounter
* SelectElements
* ShowSelectedNumbersArray
### Описание методов:
1. FillArray
Рандомно создает и возвращает массив целых чисел в диапазоне от m до k, передаваемыми вторым и третьим аргументом методу. Первый аргумент n задает длину массива.
2. ShowCollection
Выводит в цикле созданный массив
3. LargeValueCounter
Принимает в качестве первого аргумента созданный массив, вторым аргументом __value__  по умолчанию является число 8. Далее в цикле происходит подсчет количества элементов массива, значение которых больше __value__, возвращая их итоговое количество в  переменной count.
4. SelectElements
Принимает в качестве первого аргумента созданный массив, вторым аргументом __count__ передается количество элементов __count__, значение которых больше передаваемого третьим аргументом  __value__ (по условию задачи 8). Создается новый массив длиною __count__ , далее в цикле совершается проход по первому массиву и делается проверка на то, больше ли i-тый элемент 8. Если условие выполнено, значение элемента переданного массива присваивается по индексу **j** новому массиву.
5. ShowSelectedNumbersArray
Выводит новый массив, содержащий только те элементы первого массива, чье значение больше __value__, при их отсутствии выводится пустой массив.