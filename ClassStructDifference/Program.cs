//Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change.
//В классе Program создайте два метода:
//- static void ClassTaker(MyClass myClass), который присваивает полю change экземпляра
//myClass значение «изменено».
//- static void StruktTaker(MyStruct myStruct), который присваивает полю change экземпляра
//myStruct значение «изменено».
//Продемонстрируйте разницу в использовании классов и структур, создав в методе Main() экземпляры
//структуры и класса.Измените, значения полей экземпляров на «не изменено», а затем вызовите методы
//ClassTaker и StruktTaker.Выведите на экран значения полей экземпляров. Проанализируйте
//полученные результаты.
using System;

namespace ClassStructDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();

            myClass.change = "Не изменено";
            myStruct.change = "Не изменено";

            ClassTaker(myClass);
            StructTaker(myStruct);

            Console.WriteLine("Class field value: " + myClass.change + "\t Struct field value: " + myStruct.change);
        }

        static void ClassTaker(MyClass myclass)
        {
            myclass.change = "Изменено";
        }

        static void StructTaker(MyStruct mystruct)
        {
            mystruct.change = "Изменено";
        }
    }

    class MyClass
    {
        public string change;
    }

    struct MyStruct
    {
        public string change;
    }
}
