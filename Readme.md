## Задача
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

## Описание алгоритма решения:

1. Сначала мы просим пользователя ввести элементы массива.Затем мы создаем массив подстрок.

2. Далее создаем метод, который возвращает нам массив из символов с длинной <= 3. Принцип действия метода следующий: в качестве параметра мы принимаем массив из символов,который ввел пользователь. Далее мы создаем результирующий массив, в котором будут храниться элементы длинной <= 3 символам. А также создаем счетчик который будет прибавляться в случае нахождения элемента с длинной <= 3 символам,а также с помощью него мы будем заполнять результирующий массив . С помощью цикла мы перебираем все элементы нашего массива, а так-же задаем условие, если длинна нашего элемента <= 3 значит этот элемент мы добавляем в результирующий массив. Также счетчик увеличивается на 1. В конце метода мы уменьшаем размер нашего массива с помощью метода ``Arra.Resize()``.
3. Далее мы создаем метод который будет выводить в консоль массив. 
4. Далее мы создаем переменную с результирующим массивом, и с помощью метода , который ранее создали выбираем из элементов которые ввел пользователь, только те, у которых длинна <= 3.
5. Далее с помощью метода который выводит в консоль массивы, мы выводи изначальный , и результирующий массив.
