using Microsoft.Practices.Unity;

namespace StartProject
{
    internal static class Program
    {
        public static UnityContainer Container;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //DI Container configuration
            Container = new UnityContainer();
            //Container.RegisterInstance(new Hasher());    //регистрируем обьект
            //Container.RegisterType<Hasher>();          //регистрируем тип(обьект будет создан при первом обращении(иньекции))
            //Container.RegisterType<IHasher, Hasher>();   //сопоставляем (mapping)  - при обращении к IHasher выдаст Hasher
            
            Container.RegisterType<IHasher, Hasher>(
                new TransientLifetimeManager()); //Управление жизненным циклом  - правила создания обьектов при повторных запросах

            /*
            //Logger configuration - manually
            var config = new NLog.Config.LoggingConfiguration();
            var fileTarget = new NLog.Targets.FileTarget(){ FileName ="journal.log"};
            config.AddRule(              //Главная настройка - сопоставление журналов и
                NLog.LogLevel.Trace,     //минимального
                NLog.LogLevel.Fatal,     //и максимального уровней сообщений
                fileTarget               //
                );  
            //Конфигурация логера
            NLog.LogManager.Configuration = config;
            */
            //Сам логер с установленной конфигурацией - в контейнер зависимостей
            Container.RegisterInstance(
            NLog.LogManager.GetCurrentClassLogger()
                );

            Application.Run(
                //new Form1());
                Container.Resolve<Form1>());
        }
    }

    public interface IHasher
    {
        String Hash(String str);
    }

    public class Hasher:IHasher
    {
        public String Hash(String str) 
        {
            return $"Hash of {str}";
        }
    }

    public class Hasher2 : IHasher
    {
        public String Hash(String str)
        {
            return $"Hash2 of {str}";
        }
    }
}
/*
 * Ведение журнала(логирование)
 * Традиция - создавать единую систему логирования
 * 1)Классификация событий
 * 2)targets - куда попадают сообщения (журналы)
 * */

//ДЗ - Определиться с темой по курсовому проекту. Приложить название и краткое ТЗ