// Используем ресурсы Visual Basic:
using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;
// Класс с главным методом программы:
class EnteringInteger
{
    // Главный метод программы:
    static void Main()
    {
        // Тестовые переменные:
        string res, txt;
        // Целочисленные переменные:
        int year = 2022, age, born;
        // Отображение окна с полем ввода:
        res = Interaction.InputBox(
                "В каком году вы родились?", // Текст над полем ввода:
                "Год рождения"               // Название окна:
        );
        // Преобразование текста в число:
        born = Int32.Parse(res);
        // Вычисление возраста:
        age = year - born;
        txt = "Тогда Вам " + age + " лет";
        // Окно с сообщением:
        MessageBox.Show(txt, "Возраст");
    }
}