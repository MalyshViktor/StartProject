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
            //Container.RegisterInstance(new Hasher());    //������������ ������
            //Container.RegisterType<Hasher>();          //������������ ���(������ ����� ������ ��� ������ ���������(��������))
            //Container.RegisterType<IHasher, Hasher>();   //������������ (mapping)  - ��� ��������� � IHasher ������ Hasher
            
            Container.RegisterType<IHasher, Hasher>(
                new TransientLifetimeManager()); //���������� ��������� ������  - ������� �������� �������� ��� ��������� ��������

            /*
            //Logger configuration - manually
            var config = new NLog.Config.LoggingConfiguration();
            var fileTarget = new NLog.Targets.FileTarget(){ FileName ="journal.log"};
            config.AddRule(              //������� ��������� - ������������� �������� �
                NLog.LogLevel.Trace,     //������������
                NLog.LogLevel.Fatal,     //� ������������� ������� ���������
                fileTarget               //
                );  
            //������������ ������
            NLog.LogManager.Configuration = config;
            */
            //��� ����� � ������������� ������������� - � ��������� ������������
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
 * ������� �������(�����������)
 * �������� - ��������� ������ ������� �����������
 * 1)������������� �������
 * 2)targets - ���� �������� ��������� (�������)
 * */

//�� - ������������ � ����� �� ��������� �������. ��������� �������� � ������� ��