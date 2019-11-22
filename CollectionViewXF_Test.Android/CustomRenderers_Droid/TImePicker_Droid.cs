using System;
using System.ComponentModel;
using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Widget;
using CollectionViewXF_Test;
using CollectionViewXF_Test.Droid.CustomRenderers_Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using TimePicker = Xamarin.Forms.TimePicker;

[assembly: ExportRenderer(typeof(TestTimePicker), typeof(TimePicker_Droid))]
namespace CollectionViewXF_Test.Droid.CustomRenderers_Droid
{
    public class TimePicker_Droid : TimePickerRenderer, IPickerRenderer
    {
        private TimePickerDialog _dialog;

        public TimePicker_Droid(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<TimePicker> e)
        {
            base.OnElementChanged(e);

            UpdateVisual();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

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
