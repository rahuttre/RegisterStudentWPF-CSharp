/* Editor: Ryan Hutton (RH)
 * Final Project Part II 
 * SNHU - IT 230 Software Development with C#.NET
 * 12/13/2019
 */

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

namespace WPFRegisterStudent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Course choice;
        private int creditHours = 0;  // Added this variable to track registered credit hours - RH

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Course course1 = new Course("IT 145");
            Course course2 = new Course("IT 200");
            Course course3 = new Course("IT 201");
            Course course4 = new Course("IT 270");
            Course course5 = new Course("IT 315");
            Course course6 = new Course("IT 328");
            Course course7 = new Course("IT 330");

            this.comboBox.Items.Add(course1);
            this.comboBox.Items.Add(course2);
            this.comboBox.Items.Add(course3);
            this.comboBox.Items.Add(course4);
            this.comboBox.Items.Add(course5);
            this.comboBox.Items.Add(course6);
            this.comboBox.Items.Add(course7); 
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            choice = (Course)(this.comboBox.SelectedItem);

            /**************************************************************************************************
            
            // TO DO - Create code to validate user selection (the choice object)
            // and to display an error or a registation confirmation message accordinlgy
            // Also update the total credit hours textbox if registration is confirmed for a selected course

                                                COMPLETED 12/13/2019 - RH
            ***************************************************************************************************/

            /*******************************RH CODE ADDED FOR PROJECT IN THIS FUNCTION BELOW*******************/

            if (this.listBox.Items.Contains(choice) && choice.IsRegisteredAlready())
            {
                this.textBlock1.Text = "You have already registered for this " + choice.ToString() + " course";  // Add string to custom text block and print it to window.
            }
            else if (creditHours < 9)  // Total credit hours cannot exceed 9 credit hours
            {
                this.listBox.Items.Add(choice);  // Add each select to the output box of course.
                choice.SetToRegistered();
                creditHours += 3;  // Each course has 3 credit hours each and is updated.
                this.textBox.Text = Convert.ToString(creditHours);  // TextBox is the credit hour text box displayed.
                this.textBlock1.Text = "Registration confirmed for course " + choice.ToString();  // Print string when each eligible course is added.
            }
            else
                this.textBlock1.Text = "You cannot register for more than 9 credit hours.";
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //comboBox is the method for the dropbox list of courses to choose from.  
            //It does not need to be defined below to execute this project.
        }
        
        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //listBox is the method where the courses will output to.
            //It does not need to be defined below to execute this project.
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //This textBox method is the creditHours text box.
            //It does not need to be defined below to execute this project.
        }
    }
}
