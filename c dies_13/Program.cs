using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Security.Principal;

namespace c_dies_13
{
    internal class Program
    {
        public class RRRR
        {
            private const int Mult = 1103415245;
            private const int Incr = 12345;
            private const int Mod = 2342342;
            
            private int seed;

            public RRRR(int se)
            {
                seed = se;
            }
            public int Next(int min,int max)
            {
                seed = (Mult * seed + Incr) % Mod;
                return min + seed % (max - min + 1);
            }
        }
        public class Student
        {
            public string name { get; set; }
            public int age { get; set; }
            public int[] grade { get; set; }
            public int sss = 0;
            public void PRRRR()
            {
                int sum = 0;

                foreach (var a in grade)
                {
                    sum += a;
                }
                sum=sum/grade.Length;
                sss = sum;
                Console.WriteLine("Имя " + name + " \nВозраст " + age + "\nСредний балл " + sum);
            }
        }
        public class Player
        {
            public string ?name { get; set; }
            public int age { get; set; }
            public string ?position { get; set; }
            public void PPPPP()
            {
                Console.WriteLine("Имя " + name + "\nВозраст " + age + "\nПозиция " + position+"\n");
            }
        }
        public class FootballTeam
        {
            public string name { get; set; }
            public string country { get; set; }
            public int ranking { get; set; }
            public List<Player> players = new List<Player>();
            public void AddPlayer(Player pl)
            {
                players.Add(pl);
            }
            public void RemovePlayer(string nnn)
            {
                Player pll = players.FirstOrDefault(t => t.name == nnn);
                players.Remove(pll);
            }
            public List<Player> GetPlayersByPosition(string pos)
            {
                List<Player> players1 = new List<Player>();
                foreach(var d in players)
                {
                    if(d.position== pos)
                    {
                        players1.Add(d);
                    }
                }
                return players1;
            }
            public string ToJson()
            {
                string json = JsonConvert.SerializeObject(players, Formatting.Indented);
                return json;
            }


        }
        static void Main(string[] args)
        {
            //List<Student> students = new List<Student> {
            //    new Student { name="AAA",age=12,grade=new int[] { 67,88,99} },
            //new Student { name="BBB",age=54,grade=new int[] { 54,34,77} },
            //new Student { name="CCC",age=34,grade=new int[] { 12,63,96} },
            //new Student { name="DDD",age=26,grade=new int[] { 44,75,37} },
            //new Student { name="EEE",age=16,grade=new int[] { 88,87,98} } };

            //string serialized = JsonConvert.SerializeObject(students);
            //string fileName = "input.json";
            ////File.WriteAllText(fileName, serialized);

            ////List<Student> students2 = new List<Student>();
            ////Console.WriteLine(File.ReadAllText(fileName));
            ////string json = File.ReadAllText(fileName);

            //string json = System.IO.File.ReadAllText(fileName);

            //// Десериализация JSON в список объектов Student
            //List<Student> students2 = JsonConvert.DeserializeObject<List<Student>>(json);

            //// Вычисление среднего балла и вывод информации о студентах
            //foreach (var student in students)
            //{
            //    double averageGrade = CalculateAverageGrade(student.grade);

            //    Console.WriteLine("Имя: " + student.name);
            //    Console.WriteLine("Возраст: " + student.age);
            //    Console.WriteLine("Средний балл: " + averageGrade);
            //    Console.WriteLine();
            //}

            //// Сериализация списка студентов в JSON
            ////string outputJson = JsonConvert.SerializeObject(students);

            //// Сохранение JSON в файл
            //System.IO.File.WriteAllText("output.json", serialized);

            FootballTeam FT = new FootballTeam();
            FT.AddPlayer(new Player { name="AAA",age= 33, position="aba" });
            FT.AddPlayer(new Player { name = "BBB", age = 36, position = "bbb" });
            FT.AddPlayer(new Player { name = "CCC", age = 44, position = "bbb" });

            FT.AddPlayer(new Player { name = "DDD", age = 56, position = "cac" });
            Console.WriteLine(FT.ToJson());
            FT.RemovePlayer("AAA");

            Console.WriteLine(FT.ToJson());
            var LLL=FT.GetPlayersByPosition("bbb");
            foreach(var i in LLL)
            {
                i.PPPPP();
            }
        }
        static double CalculateAverageGrade(int[] grades)
        {
            double sum = 0;
            foreach (var grade in grades)
            {
                sum += grade;
            }

            return sum / grades.Length;
        }
    }
}