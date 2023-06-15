using OTD.Entity;
using OTD.WindowFolder;
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

namespace OTD
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model1 _context;
        string _id;
        public MainWindow()
        {
            InitializeComponent();
            _context = new Model1();
            
            var test = _context.Order.ToList();

            inputPosuda.Text = (_context.Order.Max(x => x.id) + 1).ToString();

        }

        /// <summary>
        /// Функция проверки заказа и временного запоминая id для последующего формирования заказа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateOrder(object sender, RoutedEventArgs e)
        {
            if (!_context.Order.Any(x=>x.id.ToString().Equals(inputPosuda.Text)))
            {
                _id = inputPosuda.Text;
                MessageBox.Show("Ваш заказ добавлен, выберете клиента");
            }
            else
            {
                MessageBox.Show("Данный код уже существует");
            }
        }

        /// <summary>
        /// Функция для обработки выбора типа лица и отображение разметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ChooisePhisFace(object sender, RoutedEventArgs e)
        {
            if (inputPhisFace.IsChecked == true)
            {
                outputPhisFace.Visibility = Visibility.Visible;
                outputLoyerFace.Visibility = Visibility.Collapsed;
            }
            else
            {
                outputPhisFace.Visibility = Visibility.Collapsed;
            }
        }

        private void ChooiseLayerFace(object sender, RoutedEventArgs e)
        {
            if (inputLoyerFace.IsChecked == true)
            {
                outputLoyerFace.Visibility = Visibility.Visible;
                outputPhisFace.Visibility = Visibility.Collapsed;
            }
            else
            {
                outputLoyerFace.Visibility = Visibility.Collapsed;
            }
        }

        private void AddClientOnOrder(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_context.PhisicalFace.Any(x => x.FIO.ToLower().Equals(inputFio.Text.ToLower())))
                {
                    MessageBox.Show("Клиент добавлен");
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("Хотите добавить клиента?", "Инфо", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        ModalWindow modalWindow = new ModalWindow();
                        if (modalWindow.ShowDialog() == true)
                        {
                            MessageBox.Show(modalWindow.Test);
                        }
                    }
                }
            }catch (Exception ex) 
            {
                MessageBox.Show("Что-то пошло нетак", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
    }
}
