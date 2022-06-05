using System.Collections.Generic;
using System.Windows;

namespace CardPickerUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            int value = (int)numberOfCards.Value;
            HashSet<string> cards = CardPickerUI.CardPicker.RandomCardPicker(value);
            foreach (string card in cards)
            {
                listBox.Items.Add(card);
            }
        }
    }
}
