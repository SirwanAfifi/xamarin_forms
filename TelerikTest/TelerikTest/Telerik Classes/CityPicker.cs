using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Telerik.XamarinForms.Input.DataForm;
using TelerikTest.Models;

namespace TelerikTest.Telerik_Classes
{
    public class CityPicker: PropertyDataSourceProvider
    {
        public override IList GetSourceForKey(object key)
        {
            if ((string)key == "City")
            {
                return new List<string> { "Tokyo", "London", "Paris", "New York City", "Brussels", "Moskow", "Berlin", "Sofia", "Boston" };
            }

            return null;
        }
    }
}
