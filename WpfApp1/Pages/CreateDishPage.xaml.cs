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
using WpfApp1.DataBase;
namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для CreateDishPage.xaml
    /// </summary>
    public partial class CreateDishPage : Page
    {
        private FastFoodEntities entities;
        public List<Ingredient> Ingredients { get; set; }
        public CreateDishPage()
        {
            InitializeComponent();
            entities = new FastFoodEntities();
            Ingredients = entities.Ingredient.ToList();
        }        
    }
}
