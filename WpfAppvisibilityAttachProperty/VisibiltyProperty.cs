using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppvisibilityAttachProperty
{
    public  class VisibiltyProperty
    {


        public static bool GetVisibiltyProperty(DependencyObject obj)
        {
            return (bool)obj.GetValue(VisibiltyPropertyProperty);
        }

        public static void SetVisibiltyProperty(DependencyObject obj, int value)
        {
            obj.SetValue(VisibiltyPropertyProperty, value);
        }

        // Using a DependencyProperty as the backing store for VisibiltyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty VisibiltyPropertyProperty =
            DependencyProperty.RegisterAttached("VisibiltyProperty", typeof(bool), typeof(VisibiltyProperty), 
                new PropertyMetadata(true,(a,b)=>
            { 
                UIElement u=(UIElement)a;
                var currenvalue=(bool)a.GetValue(VisibiltyPropertyProperty);
                if (currenvalue)
                {
                    u.Visibility = Visibility.Visible;
                }
                else
                { 
                    u.Visibility = Visibility.Collapsed;
                
                }

            }
            
            ));


    }
}
