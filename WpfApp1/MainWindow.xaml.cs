using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            combobox1.Items.Add("Видеогастроскоп Olympus GIF H180J");
            combobox2.Items.Add("спрей 10% Sol Lidicaini");
            combobox3.Items.Add("Свободно проходим");
            combobox3.Items.Add("Сужен");
            combobox3.Items.Add("Расширен");
            combobox4.Items.Add("Эластичны");
            combobox4.Items.Add("Регидны");
            combobox5.Items.Add("Бледно-розовая");
            combobox5.Items.Add("Гиперелирована");
            combobox6.Items.Add("Гладкая");
            combobox6.Items.Add("Зернистая");
            combobox7.Items.Add("Выражена");
            combobox7.Items.Add("Не выражена");
            combobox8.Items.Add("Ровная");
            combobox8.Items.Add("Неровная");
            combobox9.Items.Add("Снижается");
            combobox9.Items.Add("Не снижается");
            combobox9.Items.Add("Снижается неполностью");
            combobox10.Items.Add("Плотно");
            combobox10.Items.Add("Неплотно");
            combobox10.Items.Add("НЕ");
            combobox11.Items.Add("Обычных размером");
            combobox11.Items.Add("Расширен");
            combobox11.Items.Add("Уменьшен в размерах");
            combobox11.Items.Add("Деформирован");
            combobox12.Items.Add("Ослизненная жидкость");
            combobox12.Items.Add("Желчь");
            combobox12.Items.Add("Кровь");
            combobox12.Items.Add("Пищевые массы");
            combobox13.Items.Add("Обычных размеров");
            combobox13.Items.Add("Увеличены");
            combobox13.Items.Add("Уплощены");
            combobox14.Items.Add("Полностью");
            combobox14.Items.Add("Не полностью");
            combobox14.Items.Add("Не расправляются");
            combobox15.Items.Add("Бледно-розовая");
            combobox15.Items.Add("Гиперемирована");
            combobox16.Items.Add("Не выражен");
            combobox16.Items.Add("Усилен");
            combobox17.Items.Add("Вялая");
            combobox17.Items.Add("Активная");
            combobox18.Items.Add("Округлый");
            combobox18.Items.Add("Овальной");
            combobox18.Items.Add("Неправильной");
            combobox19.Items.Add("Проходим");
            combobox19.Items.Add("Не проходим");
            combobox20.Items.Add("Не деформирована");
            combobox20.Items.Add("Деформирована");
            combobox21.Items.Add("Бледно-розовая");
            combobox21.Items.Add("Гиперемирована");
            combobox22.Items.Add("Ворсинчатая");
            combobox22.Items.Add("Гладкая");
            combobox22.Items.Add("Зернистая");
            combobox23.Items.Add("Бледно-розовая");
            combobox23.Items.Add("Гиперемирована");
            combobox24.Items.Add("Есть");
            combobox24.Items.Add("Нет");
            combobox25.Items.Add("Не изменена");
            combobox25.Items.Add("Изменена");

        }
    }
}
