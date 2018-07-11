using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Util;
using System;

namespace RadioBtns_0
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var radioGrp = FindViewById<RadioGroup>(Resource.Id.radioGroup1);

            radioGrp.CheckedChange += delegate {
                var btnTxt = FindViewById<RadioButton>(radioGrp.CheckedRadioButtonId).Text;

                // prints to screen & saves to a file
                //Log.Debug("----DEBUG----", "radioBtn id: " + radioGrp.CheckedRadioButtonId);
                Log.Debug("----DEBUG----", "radioBtn text: " + btnTxt); 
                //Console.WriteLine("radio btn clicked");  // this works too but doesn't save to a file
            };
        }
    }
}

