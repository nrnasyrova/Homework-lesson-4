using System;

namespace HomeworkLesson4Library
{
    //classes for the 1st assignment
    public class Rectangle
    {
        private double _side1;
        private double _side2;

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }

        public Rectangle(double side1, double side2)
        {
            this._side1 = side1;
            this._side2 = side2;
        }

        private double AreaCalculator()
        {
            return _side1 * _side2;
        }

        private double PerimeterCalculator()
        {
            return (_side1 + _side2) * 2;
        }
    }

    //classes for the 2nd assignment
    public class Book
    {
        Title title = new Title();
        Author author = new Author();
        Content content = new Content();

        public Book(string title, string author, string content)
        {
            this.title.BookTitle = title;
            this.author.AuthorName = author;
            this.content.BookContent = content;
        }
        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }

    public class Title
    {
        public string BookTitle;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Title of the book: {BookTitle}");
        }
    }

    public class Author
    {
        public string AuthorName;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The author of the book: {AuthorName}");

        }
    }

    public class Content
    {
        public string BookContent;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"The book is about {BookContent}");
            Console.ResetColor();
        }
    }

    //class for the 3rd assignment
    public class Scales
    {
        private string _model;
        private string _color;
        private double _price;
        private int maxWeight = 150;
        public Scales(string model, string color, double price)
        {
            _model = model;
            _color = color;
            _price = price;
        }

        public void Weigh(int weight)
        {
            if (weight >= maxWeight)
            {
                Console.WriteLine($"Эти весы не могут взвесить более {maxWeight}");
            }
            else
            {
                Console.WriteLine($"Ваш вес составляет {weight}");
            }
        }
    }

    //classes for the 4th assignment
    public class Converter
{
    private double _usd;
    private double _eur;
    private double _rub;

    public Converter(double usd, double eur, double rub)
    {
        _usd = usd;
        _eur = eur;
        _rub = rub;
    }

    public void ConvertToSomoni(bool usd, bool eur, bool rub)
    {
        if (usd)
        {
            Console.WriteLine(Math.Round((_usd * 11.33), 2));

        }
        if (eur)
        {
            Console.WriteLine(Math.Round((_eur * 13.95), 2));

        }
        if (rub)
        {
            Console.WriteLine(_rub * 0.1535);
        }
    }
        public void ConvertFromSomoni(bool usd, bool eur, bool rub)
    {
        if (usd)
        {
            Console.WriteLine(Math.Round((_usd / 11.33), 2));
        }
        if (eur)
        {
            Console.WriteLine(Math.Round((_eur / 13.95), 2));
        }
        if (rub)
        {
            Console.WriteLine(Math.Round((_rub / 0.1535), 2));
        }
    }
}

    //classes for the 5th assignment
public class Employee
{
    private string _name;
    private string _surname;
    private string _position;
    private int _experience;
    public string Position
    { 
        get
        {
            return _position;
        } 
        set
        {
            if (value != "manager" || value != "administrator")
            {
                Console.WriteLine("Position can only be manager or admin");
            }
            else
            {
                _position = value;
            }
        }
        }

    public int Experience
    {
        get
        {
            return _experience;
        }

        set
        {
            if (value < 0)
            {
                Console.WriteLine("Experience can not be less than 0 :)");
            }
            else if (value > 82)
            {
                Console.WriteLine("Experience can not be more than 82");
            }
            else
            {
                _experience = value;
            }
        }
    }

    public Employee(string name, string surname, string position, int experience)
    {
        _name = name;
        _surname = surname;
        _position = position;
        _experience = experience;
    }

    public void CalculateSalary()
    {
        if (Position.Equals("manager"))
        {
            int salary = 1000 + 1000 * (Experience * 5) / 100;
            double taxes = (salary * 13/100) + (salary * 1/100);
            Console.WriteLine($"Name: {_name}, surname: {_surname}, position: {Position}, salary: {salary}, taxes: {Math.Round((taxes), 2)}");
        }
        if (Position.Equals("administrator"))
        {
            int salary = 800 + 800 * (Experience * 5) / 100;
            double taxes = (salary * 13/100) + (salary * 1/100);
            Console.WriteLine($"Name: {_name}, surname: {_surname}, position: {Position}, salary: {salary}, taxes: {Math.Round((taxes), 2)}");
        }
    }
}
}

