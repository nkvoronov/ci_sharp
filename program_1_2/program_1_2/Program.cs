// Использование пространство имен:
using System.Windows.Forms;
// Класс с главным методом программы:
class DialogDemo
{
    // Главный метод программы:
    static void Main ()
    {
        // Отображение диалогового окна:
        MessageBox.Show("Продолжаем изучать C#",   // Сообщение
                        "Окно с названием",        // Название окна
                        MessageBoxButtons.OK,      // Кнопки (Одна OK)
                        MessageBoxIcon.Information // Иконка
            );
    }
}