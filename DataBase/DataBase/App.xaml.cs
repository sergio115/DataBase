using DataBase.Data;
using DataBase.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DataBase
{
    public partial class App : Application
    {
        static TodoItemDatabase database;

        public App()
        {
            InitializeComponent();

            var nav = new NavigationPage(new ProductListPage());
            nav.BarBackgroundColor = Color.Azure;
            nav.BarTextColor = Color.White;
            MainPage = nav;
        }

        public static TodoItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new TodoItemDatabase(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
                }
                return database;
            }

            set => database = value;
        }

        public int ResumeAtToId { get; set; }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        
    }
}
