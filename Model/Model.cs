// Author: Alexey Boinskij, MITA DEV15-03
// HowmeWork 1 
// Date: 25 oct 2015

namespace Model
{
    // Кошка
    public class Cat
    {
        private string _name;

        // Heath[int] – private Field, изменяемое функциями Feed и Punish;
        // FR002: У купленной кошки здоровье 5
        // (Имя без подчёркивания, так как в ТЗ так написано)
        private int Health = 5;

        public Cat(string age)
        {
            // FR001: Возраст кошки вводит пользователь при покупке
            Age = age;
        }

        // Name[string] – write first Property;
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
            }
        }

        // Age[string] – read only Property;
        public string Age { get; }

        // Color[CatColor] – read/write property;
        // FR005: Система должна позволять изменить цвет кошки
        public CatColor Color { get; set; } = new CatColor();

        // CurrentColor[string] – вычисляемое поле. Результат 
        // дает на основании свойств Heath и Color.
        // FR07: Система должна позволять узнавать информацию о состоянии
        // здоровья кошки по ее окрасу: при здоровье меньше 5 выводим
        // больной цвет, иначе – здоровый цвет
        public string CurrentColor => Health >= 5 ? Color.HealthyColor : Color.SickColor;

        // Feed () – public Function;
        public void Feed()
        {
            Health++;
        }

        // Punish () – public Function;
        public void Punish()
        {
            Health--;
        }
    }

    // Цвет кошки
    public class CatColor
    {
        // FR003: У купленной кошки белый цвет в здоровом состоянии и зеленый
        // цвет в больном состоянии

        // Name[string] – write first Property;
        public string HealthyColor { get; set; } = "white";

        // SickColor[string] - read/write property.
        public string SickColor { get; set; } = "green";
    }

}
