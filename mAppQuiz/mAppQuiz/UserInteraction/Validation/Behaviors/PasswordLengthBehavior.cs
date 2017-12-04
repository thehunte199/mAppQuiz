using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mAppQuiz.Behaviors.Validation.Rules
{
    public class PasswordLengthBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);

            bindable.TextChanged += BindableOnTextChanged;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);

            bindable.TextChanged -= BindableOnTextChanged;
        }

        private void BindableOnTextChanged(object sender, TextChangedEventArgs e)
        {
            var pass = sender as Entry;
            if (e.NewTextValue.Length > 8)
            {
                pass.BackgroundColor = Color.Transparent;
            }
            else
            {
                pass.BackgroundColor = Color.Red;
            }
        }
    }
}