using System;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Widget;
using CollectionViewXF_Test;
using CollectionViewXF_Test.Droid.CustomRenderers_Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(TestEditor), typeof(EditorRenderer_Droid))]
namespace CollectionViewXF_Test.Droid.CustomRenderers_Droid
{
    public class EditorRenderer_Droid : EditorRenderer
    {
        public EditorRenderer_Droid(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            UpdateVisual();
        }

        private void UpdateVisual()
        {
            var nativeEditor = (EditText)Control;

            var gradientDrawable = new GradientDrawable();

            gradientDrawable.SetCornerRadius(10);
            gradientDrawable.SetStroke(2, Xamarin.Forms.Color.Black.ToAndroid());
            gradientDrawable.SetColor(Xamarin.Forms.Color.Wheat.ToAndroid());

            nativeEditor.SetBackground(gradientDrawable);
        }

    }
}
