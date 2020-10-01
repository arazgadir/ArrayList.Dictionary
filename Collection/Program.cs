using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;


namespace inheritance

{


    //    1) Создать базовый класс Student, который будет содержать информацию о студенте(фамилия, курс обучения, номер зачетной книги).
    //С помощью механизма наследование реализовать класс Aspirant(аспирант – студент, который готовится к защите кандидатской диссертации). Класс Aspirant есть производным от класса Student.
    //В классах Student и Aspirant необходимо реализовать следующие элементы:


    //конструкторы классов с соответствующим количеством параметров.В классе Aspirant для доступа к методам класса Student нужно использовать ключевое слово base;
    //    свойства get/set для доступа к полям класса;
    //    метод Print(), который выводит информацию о содержимом полей класса.


    //    Класс Aspirant и класс Student унаследоваться от Абстрактного класса Person.Класс Person реализовать общими свойствами, полями и методами классов Student и Aspirant.
    //Абстрактный класс People необходимо реализовать следующие элементы:
    //конструкторы классов с соответствующим количеством параметров. 
    //свойства get/set для доступа к полям класса;
    //    метод Print(), который выводит информацию о содержимом полей класса и продумать как переопределить их в производных классах.



    //    Далее создать список(ArrayList), также LinkedList студентов и аспирантов и выводить их на экран.
    //    Создайте методы вывода на экран, сортировку этих коллекций, используя методы ArrayList и LinkedList




    abstract class Person
    {

        public virtual string Lastname { set; get; }

        public abstract int Course { get; set; }
        public virtual int Numbook { get; set; }


        public Person()                                           // Конструктор по умолчанию
        {

        }

        public Person(string lastname, int course, int numbook)      // Специализированный
                                                                     // конструктор
        {

            Lastname = lastname;
            Course = course;
            Numbook = numbook;

        }

        public abstract void Print();                                                                     // METOD PECHATI 

    }

    class Student : Person                                                                         // KLASS STUDENT

    {
        private int course;

        public override int GetHashCode()
        {
            return Lastname.GetHashCode();
        }

        public override int Course
        {

            set

            {
                if (value >= 5)
                {
                    course = 4;

                }
                else if (value < 1)
                {

                    course = 1;
                }
                else
                {
                    course = value;
                }
            }

            get
            {
                return course;

            }


        }


        public Student() : base()
        {

        }

        public Student(string lastname, int course, int numbook)                                                            // VIZOV KONSTRUKTORA BAZI
              : base(lastname, course, numbook)
        {

        }


        public override void Print()
        {



            while (true)
            {
                Console.Write("\tВведите фамилию студента :  ");
                Lastname = (Console.ReadLine());


                int validation;
                if (!int.TryParse(Lastname, out validation))
                {

                    Console.WriteLine();
                    break;
                }
                Console.WriteLine("\tВы ввели числа. Ведите снова");


            }



            while (true)
            {


                try
                {
                    Console.Write("\tКурс обучения  :  ");
                    Course = int.Parse(Console.ReadLine());
                    break;

                }
                catch (Exception)
                {

                    Console.WriteLine("\tПожалуйста введите только число");
                }
            }

            while (true)
            {


                try
                {
                    Console.Write("\tНомер зачетной книжки  :  ");
                    Numbook = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("\tПожалуйста введите только число");
                }
            }



            Console.WriteLine();

            Console.WriteLine($" \t\tLastname of Student : {Lastname}  \n\t\tCourse : {Course}  \n \t\tNumber of Book : {Numbook}\n");

        }

    }

    class Aspirant : Person                                                                                                         // KLASS ASPIRANT
    {

        private int course;

        public int Disertation { get; set; }

        public override int Course
        {

            set

            {
                if (value >= 3)
                {
                    course = 2;

                }
                else if (value < 1)
                {

                    course = 1;
                }
                else
                {
                    course = value;
                }
            }

            get
            {
                return course;

            }


        }


        public Aspirant() : base()
        {

        }


        public Aspirant(string lastname, int course, int numbook, int disertation)                                                            // VIZOV KONSTRUKTORA BAZI
            : base(lastname, course, numbook)

        {
            Disertation = disertation;
        }


        public override void Print()
        {

            while (true)
            {
                Console.Write("\tВведите фамилию аспиранта :  ");

                Lastname = (Console.ReadLine());


                int validation;
                if (!int.TryParse(Lastname, out validation))
                {

                    Console.WriteLine();
                    break;
                }

                Console.WriteLine("\tВы ввели числа. Ведите снова");


            }



            while (true)
            {


                try
                {
                    Console.Write("\tКурс обучения  :  ");
                    Course = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("\tПожалуйста введите только число");
                }
            }



            while (true)
            {


                try
                {
                    Console.Write("\tНомер зачетной книжки  :  ");
                    Numbook = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("\tПожалуйста введите только число");
                }
            }



            while (true)
            {


                try
                {
                    Console.Write("\tНомер диссертации :  ");
                    Disertation = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("\tПожалуйста введите только число");
                }
            }




            Console.WriteLine();

            Console.WriteLine($" \t\tLastname of Aspirant : {Lastname}  \n \t\tCourse : {Course}  \n \t\tNumber of Book : {Numbook}   \n \t\tNum of Disertation : {Disertation}\n");

        }


    }

    class DataExam
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return $"{Day}.{Month}.{Year}\n";
        }
    }

    class Info
    {


    }

    class program
    {

        static void Main(string[] args)
        {



            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();

            Aspirant aspirant1 = new Aspirant();
            Aspirant aspirant2 = new Aspirant();
            Aspirant aspirant3 = new Aspirant();


            var Students = new ArrayList();
            var Aspirants = new ArrayList();

            Students.AddRange(new Student[] { student1, student2, student3 });
            Aspirants.AddRange(new Aspirant[] { aspirant1, aspirant2, aspirant3 });

            

            //ArrayList Students = new ArrayList();
            //ArrayList Aspirants = new ArrayList();

            //Student[] Students =
            //{ student1, student2, student3};

            //Aspirant[] Aspirants =
            //{ aspirant1, aspirant2, aspirant3};

            //Students.AddRange(new Student[] { student1, student2, student3 });
            //Aspirants.AddRange(new Aspirant[] { aspirant1, aspirant2, aspirant3 });

            //LinkedList<Aspirant> link1 = new LinkedList<Aspirant>(Aspirants);
            //link1.AddFirst(aspirant1);
            //link1.AddFirst(aspirant2);
            //link1.AddLast(aspirant3);

            //LinkedList<Student> link = new LinkedList<Student>(Students);
            //link.AddFirst(student1);
            //link.AddFirst(student2);
            //link.AddLast(student3);

            void GetStudentInfo()
            {
                Console.WriteLine("\t\tДобро пожаловать в Студенческий лагерь \n".ToUpper());
                int s = 1;
                foreach (var item in Students)
                {
                    Console.WriteLine($"Информация о {s} Студенте: ".ToUpper());
                    ((Student)Students[0]).Print();
                    s++;
                }

                
                Console.WriteLine("Дата экзамена: ");
                DataExam ExamS = new DataExam { Day = 07, Month = 11, Year = 2020 };
                Console.WriteLine(ExamS.ToString());                                                 // TO STRING  DATE


                Console.WriteLine("Если нужна еще информация выберите пункт 1 или 2. Для выхода нажмите кнопку Х на правом верхнем углу\n");

            }

            void GetAspirantInfo()
            {

                Console.WriteLine("\t\tДобро пожаловать в Лагерь Аспирантов\n".ToUpper());
                int a = 1;
                foreach (var item in Aspirants)
                {
                    Console.WriteLine($"Информация о {a} Студенте: ".ToUpper());
                    ((Aspirant)Aspirants[0]).Print();
                    a++;
                }

                


                Console.WriteLine("Дата экзамена: ");
                DataExam ExamA = new DataExam { Day = 12, Month = 11, Year = 2020 };
                Console.WriteLine(ExamA.ToString());                                               // TO STRING DATE 


                Console.WriteLine("Если нужна еще информация выберите пункт 1 или 2. Для выхода нажмите кнопку Х на правом верхнем углу\n");

            }


            LinkedList<Student> LSudents = new LinkedList<Student>();
            LinkedListNode<Student> tom = LSudents.AddLast(new Student() { });
            LSudents.AddLast(student1);
            LSudents.AddFirst(student2);
            LSudents.AddAfter(LSudents.Last, student3);
            foreach (var item in LSudents)
            {
                Console.WriteLine(item);
            }
            LinkedList<Aspirant> LAspirants = new LinkedList<Aspirant>();
            LAspirants.AddLast(aspirant1);
            LAspirants.AddFirst(aspirant2);
            LAspirants.AddAfter(LAspirants.First, aspirant3);
            foreach (var item in LAspirants)
            {
                Console.WriteLine(item);
            }

            Dictionary<char, Person> people = new Dictionary<char, Person>();
            people.Add('b', new Student() { Lastname = "Bill" });
            people.Add('t', new Student() { Lastname = "Tom" });
            people.Add('j', new Student() { Lastname = "John" });



            foreach (KeyValuePair<char, Person> keyValue in people)
            {
                // keyValue.Value представляет класс Person
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value.Lastname);
            }






            Console.WriteLine("\t\t Д о б р о   п о ж а л о в а т ь   в   Г а р в а р д. \n".ToUpper());

            do
            {
                Console.WriteLine("Код : 1 - Студенческий лагерь________________Код: 2 - Лагерь аспирантов  \n");


                string selection = (Console.ReadLine());
                switch (selection)

                {
                    case "1":

                        GetStudentInfo();
                        break;

                    case "2":

                        GetAspirantInfo();
                        break;
                }

            } while (true);




        }
    }
}
