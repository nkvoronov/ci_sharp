// Используем ресурсы Visual Basic:
using Microsoft.VisualBasic;
using System.Windows.Forms;
// Класс с главным методом программы:
class InputDialogDemo
{
    // Главный метод программы:
    static void Main()
    {
        // Тестовая переменная:
        string name;
        // Отображение окна с полем ввода:
        name = Interaction.InputBox(
                "Как Вас зовут?",         // Текст над полем ввода:
                "Давайте познакомимся..." // Название окна
        );
        // Еще одна тестовая переменная:
        string txt = "Очень приятно, "+name+"!";
        // Отображение диалогового окна:
        MessageBox.Show(txt, "Знакомство состоялось");
    }
}