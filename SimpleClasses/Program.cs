using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        public class Abiturient
        {
            protected string name;
            protected string surname;
            protected string middlename;
            protected string adress;
            protected string num_of_atestat;
            protected string school;
            protected double[] zno_res;

            public string GetName() { return name; }
            public string GetSurmane() { return surname; }
            public string GeTMiddlename() { return middlename; }
            public string GetAdress() { return adress; }
            public string GetNumAtest() { return num_of_atestat; }
            public string GetSchool() { return school; }
            public double[] GetZno() { return zno_res; }

            public void SetName(string n) { name = n; }
            public void SetSurname(string s) { surname = s; }
            public void SetMiddlename(string m) { middlename = m; }
            public void SetAdress(string a) { adress = a; }
            public void SetNumAtest(string n) { num_of_atestat = n; }
            public void SetSchool(string sc) { school = sc; }
            public void SetZno(double[] z) { zno_res = z; }

            public void Show()
            {
                Console.WriteLine("Ім'я - " + name);
                Console.WriteLine("Прізвище - " + surname);
                Console.WriteLine("Побатькові - " + middlename);
                Console.WriteLine("Адреса - " + adress);
                Console.WriteLine("Номер атестату - " + num_of_atestat);
                Console.WriteLine("Школа - " + school);
                Console.WriteLine("Результати ЗНО - " + zno_res[0] + "  " + zno_res[1] + "  " + zno_res[2]);

            }

            public Abiturient()
            {
                name = "Name";
                surname = "Surname";
                middlename = "Middlename";
                adress = "Adress";
                num_of_atestat = "Number";
                school = "School";
                zno_res = new double[3];
                for (int i = 0; i < zno_res.Length; i++)
                {
                    zno_res[i] = 0;
                }
            }
            public Abiturient(string n, string s, string m, string a, string num, string sc, double z1, double z2, double z3)
            {
                zno_res = new double[3];
                name = n;
                surname = s;
                middlename = m;
                adress = a;
                num_of_atestat = num;
                school = sc;
                zno_res[0] = z1;
                zno_res[1] = z2;
                zno_res[2] = z3;
            }
            public Abiturient(Abiturient a)
            {
                this.name = a.name;
                this.surname = a.surname;
                this.middlename = a.middlename;
                this.adress = a.adress;
                this.num_of_atestat = a.num_of_atestat;
                this.school = a.school;
                this.zno_res = a.zno_res;
            }
        }

        public class Bus
        {
            protected string name;
            protected string number_of_bus;
            protected int number_of_way;
            protected string mark;
            protected int year;
            protected int run;

            public string GetName() { return name; }
            public string GetNumBus() { return number_of_bus; }
            public int GetNumWay() { return number_of_way; }
            public string GetMark() { return mark; }
            public int GetYear() { return year; }
            public int GetRun() { return run; }

            public void SetName(string n) { name = n; }
            public void SetNumBus(string nb) { number_of_bus = nb; }
            public void SetNumWay(int nw) { number_of_way = nw; }
            public void SetMark(string m) { mark = m; }
            public void SetYear(int y) { year = y; }
            public void SetRun(int r) { run = r; }

            public void Show()
            {
                Console.WriteLine("Ім'я - " + name);
                Console.WriteLine("Номер автобуса - " + number_of_bus);
                Console.WriteLine("Номер маршруту - " + number_of_way);
                Console.WriteLine("Марка автобуса - " + mark);
                Console.WriteLine("Рік випуску - " + year);
                Console.WriteLine("Пробіг - " + run);
                
            }

            public Bus()
            {
                name = "Name";
                number_of_bus = "AA0000AA";
                number_of_way = 1;
                mark = "Mercedes-Benz";
                year = 2010;
                run = 155000;
            }
            public Bus(string n, string nb, int nw, string m, int y, int r)
            {
                name = n;
                number_of_bus = nb;
                number_of_way = nw;
                mark = m;
                year = y;
                run = r;
            }
            public Bus(Bus a)
            {
                this.name = a.name;
                this.number_of_bus = a.number_of_bus;
                this.number_of_way = a.number_of_way;
                this.mark = a.mark;
                this.year = a.year;
                this.run = a.run;
            }
        }

        public class Person
        {
            protected string name;
            protected string surname;
            protected string middlename;
            protected string adress;
            protected string gender;
            protected string education;
            protected int year_of_birth;
            protected int salary;

            public string GetName() { return name; }
            public string GetSurname() { return surname; }
            public string GetMiddleName() { return middlename; }
            public string GetAdress() { return adress; }
            public string GetGender() { return gender; }
            public string GetEducation() { return education; }
            public int GetYear() { return year_of_birth; }
            public int GetSalary() { return salary; }

            public double GetSalaryInDollars
            {
                get
                {
                    return Math.Round((salary / 25.78),2);
                }
            }
            public int SetSal
            {
                set
                {
                    if (value > 0)
                    {
                        salary = value;
                    }
                    else { salary = 0; }
                }
            }
            public int YearOfBirth
            {
                get
                {
                    return year_of_birth;
                }
                set
                {
                    if (value > 2016 || value < 1900)
                    {
                        Console.WriteLine("Невірно вказаний рік народження");
                    }
                    else
                    {
                        year_of_birth = value;
                    }
                }
            }
            public string Surname { get; set; }



            public void SetName(string n) { name = n; }
            public void SetSurname(string s) { surname = s; }
            public void SetMiddlename(string m) { middlename = m; }
            public void SetAdress(string a) { adress = a; }
            public void SetGender(string gd) { gender = gd; }
            public void SetEducation(string e) { education = e; }
            public void SetYear(int y) { year_of_birth = y; }
            public void SetSalary(int sal) { salary = sal; }

            public void Show()
            {
                Console.WriteLine("Ім'я - " + name);
                Console.WriteLine("Прізвище - " + surname);
                Console.WriteLine("Побатькові - " + middlename);
                Console.WriteLine("Адреса - " + adress);
                Console.WriteLine("Стать - " + gender);
                Console.WriteLine("Освіта - " + education);
                Console.WriteLine("Рік народження - " + year_of_birth);
                Console.WriteLine("Зарплата - " + salary);
            }
            public Person()
            {
                name = "Іван";
                surname = "Іванов";
                middlename = "Іванович";
                adress = "вул. Київська, 27";
                gender = "м";
                education = "вища";
                year_of_birth = 1990;
                salary = 2500;
            }
            public Person(string n, string s, string m, string a, string g, string e, int y, int sal)
            {
                name = n;
                surname = s;
                middlename = m;
                adress = a;
                gender = g;
                education = e;
                year_of_birth = y;
                salary = sal;
            }
            public Person(Person a)
            {
                this.name = a.name;
                this.surname = a.surname;
                this.middlename = a.middlename;
                this.adress = a.adress;
                this.gender = a.gender;
                this.education = a.education;
                this.year_of_birth = a.year_of_birth;
                this.salary = a.salary;
            }
            
        }

        public class ArrClass
        {
            protected Abiturient[] abiturients;
            protected Bus[] buses;
            protected Person[] persons;

            public void InputAb()
            {
                string[] s = File.ReadAllLines(@"abiturients.txt");
                abiturients = new Abiturient[s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    string[] x = s[i].Split('/');
                    double zno1 = double.Parse(x[6]);
                    double zno2 = double.Parse(x[7]);
                    double zno3 = double.Parse(x[8]);
                    abiturients[i] = new Abiturient(x[0], x[1], x[2], x[3], x[4], x[5], zno1, zno2, zno3);
                }
            }
            public void ShowAb()
            {
                foreach (Abiturient x in abiturients)
                {
                    x.Show();
                    Console.WriteLine();
                }
            }
            public void InputBs()
            {
                string[] s = File.ReadAllLines(@"buses.txt");
                buses = new Bus[s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    string[] x = s[i].Split('/');
                    buses[i] = new Bus(x[0], x[1], int.Parse(x[2]), x[3], int.Parse(x[4]), int.Parse(x[5]));
                }
            }
            public void ShowBs()
            {
                foreach (Bus b in buses)
                {
                    b.Show();
                    Console.WriteLine();
                }
            }
            public void InputPs()
            {
                string[] s = File.ReadAllLines(@"persons.txt");
                persons = new Person[s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    string[] x = s[i].Split('/');

                    persons[i] = new Person(x[0], x[1], x[2], x[3], x[4], x[5], int.Parse(x[6]), int.Parse(x[7]));
                }
            }
            public void ShowPs()
            {
                foreach(Person p in persons)
                {
                    p.Show();
                    Console.WriteLine();
                }
            }
            public void SearchAb()
            {
                Console.Clear();
                Console.WriteLine("1. Пошук за іменем");
                Console.WriteLine("2. Пошук за прізвищем");
                Console.WriteLine("3. Пошук за побатькові");
                Console.WriteLine("4. Пошук за адресою");
                Console.WriteLine("5. Пошук за номером атестату");
                Console.WriteLine("6. Пошук за номером школи");
                Console.WriteLine("7. Пошук за результатами ЗНО");
                Console.Write("Оберіть варіант пошуку - ");
                int v = int.Parse(Console.ReadLine());
                switch (v)
                {
                    case 1:
                        Console.Write("Ім'я - ");
                        string q = Console.ReadLine();
                        foreach (Abiturient a in abiturients)
                        {
                            if (q == a.GetName())
                            {
                                Console.WriteLine();
                                a.Show();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        break;
                    case 2:
                        Console.Write("Прізвище - ");
                        string q1 = Console.ReadLine();
                        foreach (Abiturient a in abiturients)
                        {
                            if (q1 == a.GetSurmane())
                            {
                                Console.WriteLine();
                                a.Show();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        break;
                    case 3:
                        Console.Write("Побатькові - ");
                        string q2 = Console.ReadLine();
                        foreach (Abiturient a in abiturients)
                        {
                            if (q2 == a.GeTMiddlename())
                            {
                                Console.WriteLine();
                                a.Show();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        break;
                    case 4:
                        Console.Write("Адреса - ");
                        string q3 = Console.ReadLine();
                        foreach (Abiturient a in abiturients)
                        {
                            if (q3 == a.GetAdress())
                            {
                                Console.WriteLine();
                                a.Show();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        break;
                    case 5:
                        Console.Write("Номер атестату - ");
                        string q4 = Console.ReadLine();
                        foreach (Abiturient a in abiturients)
                        {
                            if (q4 == a.GetNumAtest())
                            {
                                Console.WriteLine();
                                a.Show();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        break;
                    case 6:
                        Console.Write("Номер школи - ");
                        string q5 = Console.ReadLine();
                        foreach (Abiturient a in abiturients)
                        {
                            if (q5 == a.GetSchool())
                            {
                                Console.WriteLine();
                                a.Show();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        break;
                    case 7:
                        Console.Write("Результат ЗНО - ");
                        double q6 = double.Parse(Console.ReadLine());
                        
                        foreach (Abiturient a in abiturients)
                        {
                            double[] m = a.GetZno();
                            foreach (double y in m)
                            { 
                                if (q6 == y)
                                {
                                    Console.WriteLine();
                                    a.Show();
                                    Console.WriteLine("-----------------------------------");
                                    break;
                                }
                            }
                        }
                        break;
                    default: Console.WriteLine("Невірно введено номер"); break;
                }
            }
            public void SearchBs()
            {
                Console.Clear();
                Console.WriteLine("1. Пошук за іменем");
                Console.WriteLine("2. Пошук за номером автобуса");
                Console.WriteLine("3. Пошук за номером маршруту");
                Console.WriteLine("4. Пошук за маркою автобуса");
                Console.WriteLine("5. Пошук за роком випуску автобуса");
                Console.WriteLine("6. Пошук за пробігом автобуса");
                Console.Write("Оберіть варіант пошуку - ");
                int v = int.Parse(Console.ReadLine());
                switch (v)
                {
                    case 1:
                        Console.Write("Ім'я - ");
                        string q = Console.ReadLine();
                        foreach (Bus a in buses)
                        {
                            if (q == a.GetName())
                            {
                                Console.WriteLine();
                                a.Show();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        break;
                    case 2:
                        Console.Write("Номер автобуса - ");
                        string q1 = Console.ReadLine();
                        foreach (Bus a in buses)
                        {
                            if (q1 == a.GetNumBus())
                            {
                                Console.WriteLine();
                                a.Show();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        break;
                    case 3:
                        Console.Write("Номер маршруту - ");
                        int q2 = int.Parse(Console.ReadLine());
                        foreach (Bus a in buses)
                        {
                            if (q2 == a.GetNumWay())
                            {
                                Console.WriteLine();
                                a.Show();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        break;
                    case 4:
                        Console.Write("Марка автобуса - ");
                        string q3 = Console.ReadLine();
                        foreach (Bus a in buses)
                        {
                            if (q3 == a.GetMark())
                            {
                                Console.WriteLine();
                                a.Show();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        break;
                    case 5:
                        Console.Write("Рік випуску - ");
                        int q4 = int.Parse(Console.ReadLine());
                        foreach (Bus a in buses)
                        {
                            if (q4 == a.GetYear())
                            {
                                Console.WriteLine();
                                a.Show();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        break;
                    case 6:
                        Console.Write("Пробіг - ");
                        int q5 = int.Parse(Console.ReadLine());
                        foreach (Bus a in buses)
                        {
                            if (q5 == a.GetRun())
                            {
                                Console.WriteLine();
                                a.Show();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        break;
                    default: Console.WriteLine("Невірно введено номер"); break;
                }
            }
            public void SearchPs()
            {
                Console.Clear();
                Console.WriteLine("1. Пошук за іменем");
                Console.WriteLine("2. Пошук за прізвищем");
                Console.WriteLine("3. Пошук за побатькові");
                Console.WriteLine("4. Пошук за адресою");
                Console.WriteLine("5. Пошук за статтю");
                Console.WriteLine("6. Пошук за освітою");
                Console.WriteLine("7. Пошук за роком народження");
                Console.WriteLine("8. Пошук за зарплатою");
                Console.Write("Оберіть варіант пошуку - ");
                int v = int.Parse(Console.ReadLine());
                switch (v)
                {
                    case 1:
                        Console.Write("Ім'я - ");
                        string q = Console.ReadLine();
                        foreach (Person a in persons)
                        {
                            if (q == a.GetName())
                            {
                                Console.WriteLine();
                                a.Show();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        break;
                    case 2:
                        Console.Write("Прізвище - ");
                        string q1 = Console.ReadLine();
                        foreach (Person a in persons)
                        {
                            if (q1 == a.GetSurname())
                            {
                                Console.WriteLine();
                                a.Show();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        break;
                    case 3:
                        Console.Write("Побатькові - ");
                        string q2 = Console.ReadLine();
                        foreach (Person a in persons)
                        {
                            if (q2 == a.GetMiddleName())
                            {
                                Console.WriteLine();
                                a.Show();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        break;
                    case 4:
                        Console.Write("Адреса - ");
                        string q3 = Console.ReadLine();
                        foreach (Person a in persons)
                        {
                            if (q3 == a.GetAdress())
                            {
                                Console.WriteLine();
                                a.Show();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        break;
                    case 5:
                        Console.Write("Стать(ч/ж) - ");
                        string q4 = Console.ReadLine();
                        foreach (Person a in persons)
                        {
                            if (q4 == a.GetGender())
                            {
                                Console.WriteLine();
                                a.Show();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        break;
                    case 6:
                        Console.Write("Освіта - ");
                        string q5 = Console.ReadLine();
                        foreach (Person a in persons)
                        {
                            if (q5 == a.GetEducation())
                            {
                                Console.WriteLine();
                                a.Show();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        break;
                    case 7:
                        Console.Write("Рік народження - ");
                        int q6 = int.Parse(Console.ReadLine());
                        foreach (Person a in persons)
                        {
                            if (q6 == a.GetYear())
                            {
                                Console.WriteLine();
                                a.Show();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        break;
                    case 8:
                        Console.Write("Зарплата - ");
                        int q7 = int.Parse(Console.ReadLine());
                        foreach (Person a in persons)
                        {
                            if (q7 == a.GetSalary())
                            {
                                Console.WriteLine();
                                a.Show();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        break;
                    default: Console.WriteLine("Невірно введено номер"); break;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Abiturient A = new Abiturient("Іван", "Іванов", "Іванович", "вул. Київська, 40", "№12005", "№21", 178.5, 180.0, 147.3);
            A.Show();
            double[] mass = A.GetZno();
            Console.Write("ЗНО - ");
            foreach (double x in mass) { Console.Write(x + "  "); }
            Console.WriteLine("\n");
            Bus B = new Bus("Петров А.А.", "АМ4554АВ", 205, "Renault", 2012, 80000);
            B.SetRun(95000);
            B.Show();
            Console.WriteLine();
            Person P = new Person();
            P.Show();
            Person P1 = new Person(P);
            P1.SetName("Петро");
            P1.SetSalary(7500);
            P1.YearOfBirth = 1800;
            Console.WriteLine(P1.YearOfBirth);
            Console.WriteLine();
            P1.Show();
            P1.SetSal = -2000;
            Console.WriteLine("Зарплата в доларах для {0} {1} - {2}", P1.GetName(), P1.GetSurname(), P1.GetSalaryInDollars);
            ArrClass arr = new ArrClass();
            arr.InputAb();
            arr.ShowAb();
            arr.InputBs();
            arr.ShowBs();
            arr.InputPs();
            arr.ShowPs();
            P1.Surname = "Васильчук";
            Console.WriteLine(P1.Surname);
            Console.WriteLine("Для здійснення пошуку натисніть 'п'");
            char p = char.Parse(Console.ReadLine());
            if (p == 'g' || p == 'п')
            {
                Console.Clear();
                Console.WriteLine("1. Пошук абітурієнта");
                Console.WriteLine("2. Пошук автобуса");
                Console.WriteLine("3. Пошук персони");
                Console.Write("Оберіть категорію пошуку - ");
                int v = int.Parse(Console.ReadLine());
                switch (v)
                {
                    case 1:
                        arr.SearchAb();
                        break;
                    case 2:
                        arr.SearchBs();
                        break;
                    case 3:
                        arr.SearchPs();
                        break;
                    default: Console.WriteLine("Невірно введено номер"); break;
                }
                
            }
            else { Console.WriteLine("Невірно введено символ"); }
        }
    }
}
