// Используем ресурсы Visual Basic:
using Microsoft.VisualBasic;
using System.Windows.Forms;
// Класс с главным методом программы:
class InputDialogFIO
{
    // Главный метод программы:
    static void Main()
    {
        string fname, tname;
        fname = Interaction.InputBox(
                "Имя",         // Текст над полем ввода:
                "Введите имя"  // Название окна
        );
        tname = Interaction.InputBox(
                "Фамилия",         // Текст над полем ввода:
                "Введите фамилию"  // Название окна
        );
        // Еще одна тестовая переменная:
        string txt = fname+" "+tname;
        // Отображение диалогового окна:
        MessageBox.Show(txt, "Полное имя");
    }
}