using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational_patterns
{
    //Фабричный метод - порождающий шаблон проектирования,
    //который определяет интерфейс для создания объектов, но позволяет подклассам изменять тим создаваемых объектов.
    //Если говорить проще,это паттерн который делегирует создание объектов подклассам


    //Применимость
    //1.Хотим делегировать логику создания подклассам.
    //2.У нас реализована структура создания объектов с использования интерфейса или абстрактоного класса для дальнейшего расширения по принципу OCP
    //3.Заранее не известно типы каких объектов мы будем использовать


    //Пример использования паттерна.У нас есть заранее сайт с одной теммой(белой).Мы хотим добавить чёрную тему или например какую нибудь другую
    //Для данного случая хорошо подойдёт данный паттерн, потому что мы заранее не знаем какую тему захотим использовать
    public class FactoryMethod3
    {
        public interface IThemaa
        {
            public void ShowThema();
        }
        
        public class BlackThema:IThemaa 
        {
            public void ShowThema()
            {
                //Логика для отоброжения всех нолвых иконок с использованием текущей темы.

            }
        }
        public class WhiteThema:IThemaa 
        {
            public void ShowThema()
            {
                //Логика для отоброжения всех нолвых иконок с использованием текущей темы.
            }
        }


        public abstract class FactoryThema
        {
 
           public abstract IThemaa GenerateNewThema();
           public void Run()
            {
                IThemaa themaa = GenerateNewThema();
                themaa.ShowThema();
            }


        }

        public  class WhiteFactoryThema:FactoryThema
        {
            public override IThemaa GenerateNewThema()
            {
                return new WhiteThema();
            }


        }
        public  class BlackFactoryThema:FactoryThema
        {
            public override IThemaa GenerateNewThema()
            {
                return new BlackThema();
            }


        }
    }
}
