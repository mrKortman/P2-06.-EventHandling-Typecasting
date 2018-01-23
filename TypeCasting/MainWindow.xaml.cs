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

namespace TypeCasting
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

        public void ListBoxChanged(object sender, EventArgs e)
        {
            //CASTING

            /**
             * Casting is het omzetten van het ene data type naar het andere data type
             * Het onderliggende type van ieder data type is object.
             * Een string, boolean en int zijn ook van het type object
             * Ook alle controls in WPF zijn van het type object
             * Deze methode is een Event Handler en het eerste argument is vcan het type object
             * De Event Handler is op een ListBox control gezet
             * Een ListBox bestaat uit ListBoxItems.
             * we kunnen dit dus casten.
             * 
             * Stel dat we de tekst van het ListBoxItem willen laten zien in een label
             * kan dit als volgt :
             */

            // Meerdere regels (de makkelijke manier)
            // Uncomment om te laten werken!

            /*
            
            ListBox myListBox = (ListBox)sender;
            ListBoxItem myListBoxItem = (ListBoxItem)myListBox.SelectedItem;
            String myText = (String)myListBoxItem.Content.ToString();
            myLabel.Content = myText;
            
             */
             
            //Of je kunt dit in een regel uitvoeren (lastiger)

            myLabel.Content = ((ListBoxItem)((ListBox)sender).SelectedItem).Content.ToString();
        }
    }
}
