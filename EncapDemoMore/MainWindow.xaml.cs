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

namespace EncapDemoMore {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            //Person bob = new Person();
            //bob.FirstName = "Bob";
            Person personWeMade = new Person("tim");
            personWeMade.Height = 123456;
            personWeMade.DateOfBirth = new DateTime(1992, 2, 4);

            personWeMade.EyeColor = Person.Colors.Brown;

            if(personWeMade.EyeColor == Person.Colors.Brown) {
                MessageBox.Show(personWeMade.FullName 
                    + " has brown eyes.");
            }
           

           

        }
    }
}
