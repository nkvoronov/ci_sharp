// Используем ресурсы Visual Basic:
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;
// Класс с главным методом программы:
class InputDialogNV
{
    // Главный метод программы:
    static void Main()
    {
        string sname, sage;
        sname = Interaction.InputBox(
                "Имя",         // Текст над полем ввода:
                "Введите имя"  // Название окна
        );
        sage = Interaction.InputBox(
                "Возраст",         // Текст над полем ввода:
                "Введите возраст"  // Название окна
        );
        int age = Int32.Parse(sage);
        // Еще одна тестовая переменная:
        string txt = sname+" "+sage;
        // Отображение диалогового окна:
        MessageBox.Show(txt, "Имя и Возраст");
    }
}