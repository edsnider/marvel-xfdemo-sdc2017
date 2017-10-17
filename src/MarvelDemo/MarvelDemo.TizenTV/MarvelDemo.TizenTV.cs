using System;

namespace MarvelDemo.TizenTV
{
    class Program : global::Xamarin.Forms.Platform.Tizen.FormsApplication
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            try
            {
                LoadApplication(new App());
                Tizen.Xamarin.Forms.Extension.Renderer.TizenFormsExtension.Init();
            }
            catch (Exception e)
            {
                var ee = e;
            }
        }

        static void Main(string[] args)
        {
            var app = new Program();
            global::Xamarin.Forms.Platform.Tizen.Forms.Init(app);
            app.Run(args);
        }
    }
}
