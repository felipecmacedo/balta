using System;
using Balta.ContentContext;
using Balta.NotificationContext;
using Balta.SubscriptionContext;

namespace Balta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao/objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .Net", "dotnet"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
                Console.WriteLine("-----------");
            }


            var courses = new List<Course>();
            var courseOOP = new Course("Fundamento OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamento C#", "fundamentos-csharp");
            var courseAspNet = new Course("Fundamento ASP.NET", "fundamentos-aspnet");

            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();

            var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");

            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", null);
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseCsharp);
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);

            careerDotNet.Items.Add(careerItem2);
            careerDotNet.Items.Add(careerItem3);
            careerDotNet.Items.Add(careerItem);

            careers.Add(careerDotNet);

            foreach (var career in careers)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(career.Title);

                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }

                var payPalSubscription = new PayPalSubscription();
                var student = new Student();

                student.Subscriptions.Add(payPalSubscription);
            }
        }
    }
}