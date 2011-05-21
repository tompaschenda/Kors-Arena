using System;
using System.ComponentModel;
using System.Collections.Generic;
using Common;

namespace WarhammerGUI
{

    /// <summary>
    /// Stolen from http://roecode.wordpress.com/2008/01/15/wpf-enumcombobox-usercontrol/
    /// </summary>
    public class EnumComboBox : System.Windows.Controls.ComboBox
    {
        static EnumComboBox()
        {

            //This OverrideMetadata call tells the system that this element wants to provide a style that is different than its base class.
            //This style is defined in themes\generic.xaml
            //DefaultStyleKeyProperty.OverrideMetadata(typeof(EnumComboBox), new FrameworkPropertyMetadata(typeof(EnumComboBox)));
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            FillItems();
        }

        private string _enumType;
        [Browsable(true), Category("Data"), Description("Sets the fully qualified type of the enum to display in the DropDownList")]
        public string EnumTypeName
        {
            get { return _enumType; }
            set { _enumType = value; }
        }

        private List<KeyValuePair<int, string>> CachedValues
        {
            get
            {
                if (App.Current != null && App.Current.Properties != null)
                {
                    return (List<KeyValuePair<int, string>>)App.Current.Properties["EnumComboBox_" + EnumTypeName];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (App.Current != null && App.Current.Properties != null)
                {
                    App.Current.Properties["EnumComboBox_" + EnumTypeName] = value;
                }
            }
        }

        private void FillItems()
        {
            List<KeyValuePair<int, string>> values = CachedValues;
            if (values == null)
            {
                values = new List<KeyValuePair<int, string>>();
                Type enumType = Type.GetType(EnumTypeName);
                if (enumType == null)
                {
                    throw new ArgumentException("Cannot load the type: " + EnumTypeName);
                }
                Array enumValues = Enum.GetValues(enumType);
                for (int index = 0; index < enumValues.Length; index++)
                {
                    int value = (int)enumValues.GetValue(index);
                    Enum enumValue = (Enum)enumValues.GetValue(index);
                    values.Add(new KeyValuePair<int, string>(value, EnumExtensions.GetDescription(enumValue)));
                }
                CachedValues = values;
            }

            this.ItemsSource = values;
            this.DisplayMemberPath = "Value";
            this.SelectedValuePath = "Key";
        }
    }
}