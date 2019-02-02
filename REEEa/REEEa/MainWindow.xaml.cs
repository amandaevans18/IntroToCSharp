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
using System.Numerics;
using System.Windows.Media.Media3D;

namespace REEEa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
 

    public partial class MainWindow : Window
    {
        
        public Vector3D firstVecFromUser;
        public Vector3D secondVecFromUser;
        
        int answer;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void SumButton(object sender, RoutedEventArgs e)
        {

            firstVecFromUser = goThroughText(FirstVec3X.Text, FirstVec3Y.Text, FirstVec3Z.Text);
            secondVecFromUser = goThroughText(SecondVec3X.Text, SecondVec3Y.Text, SecondVec3Z.Text);

            Vector3D.Add(firstVecFromUser, secondVecFromUser);


        }

        private void DotProduct(object sender, RoutedEventArgs e)
        {

            firstVecFromUser = goThroughText(FirstVec3X.Text, FirstVec3Y.Text, FirstVec3Z.Text);
            secondVecFromUser = goThroughText(SecondVec3X.Text, SecondVec3Y.Text, SecondVec3Z.Text);

            Vector3D.DotProduct(firstVecFromUser, secondVecFromUser);
        }

        private void Difference(object sender, RoutedEventArgs e)
        {

            firstVecFromUser = goThroughText(FirstVec3X.Text, FirstVec3Y.Text, FirstVec3Z.Text);
            secondVecFromUser = goThroughText(SecondVec3X.Text, SecondVec3Y.Text, SecondVec3Z.Text);

            Vector3D.Subtract(firstVecFromUser, secondVecFromUser);
        }

        private void Magnitude(object sender, RoutedEventArgs e)
        {

            firstVecFromUser = goThroughText(FirstVec3X.Text, FirstVec3Y.Text, FirstVec3Z.Text);
            secondVecFromUser = goThroughText(SecondVec3X.Text, SecondVec3Y.Text, SecondVec3Z.Text);

            Vector3D.CrossProduct(firstVecFromUser, secondVecFromUser);
        }

        private void Normalize(object sender, RoutedEventArgs e)
        {

            firstVecFromUser = goThroughText(FirstVec3X.Text, FirstVec3Y.Text, FirstVec3Z.Text);
            secondVecFromUser = goThroughText(SecondVec3X.Text, SecondVec3Y.Text, SecondVec3Z.Text);

            Vector3D.AngleBetween(firstVecFromUser, secondVecFromUser);
        }

        private void Clamp(object sender, RoutedEventArgs e)
        {

            firstVecFromUser = goThroughText(FirstVec3X.Text, FirstVec3Y.Text, FirstVec3Z.Text);
            secondVecFromUser = goThroughText(SecondVec3X.Text, SecondVec3Y.Text, SecondVec3Z.Text);

            Vector3D.ReferenceEquals(firstVecFromUser, secondVecFromUser);
        }

        public Vector3D goThroughText(string Vec3X, string Vec3Y, string Vec3Z)
        {
            int vecVarisX = Convert.ToInt32(Vec3X);
            int vecVarisY = Convert.ToInt32(Vec3Y);
            int vecVarisZ = Convert.ToInt32(Vec3Z);

            Vector3D parsed = new Vector3D( vecVarisX, vecVarisY, vecVarisZ );
           

            return parsed; 
        }

    }
}
