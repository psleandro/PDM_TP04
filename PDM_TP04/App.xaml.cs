//Leandro Pereira dos Santos CB3005372
//Renan Josué Silva de Matos CB3007162

using PDM_TP04.Model;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDM_TP04
{
    public partial class App : Application
    {

        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new
            View.Aluno.MainPage());
        }
        static Aluno alunoModel;
        public static Aluno AlunoModel
        {
            get
            {
                if (alunoModel == null)
                {
                    alunoModel = new Aluno();
                }
                return alunoModel;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
