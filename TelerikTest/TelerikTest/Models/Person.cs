
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Common.DataAnnotations;

namespace TelerikTest.Models
{
    public class Person : NotifyPropertyChangedBase
    {

        private string firstName;
        [DisplayOptions(Header = "نام")]
        [NonEmptyValidator("نام الزامی است")]
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (this.firstName != value)
                {
                    this.firstName = value;
                    this.OnPropertyChanged();
                }
            }
        }

        private string lastName;
        [DisplayOptions(Header = "نام خانوادگی")]
        [NonEmptyValidator("نام خانوادگی الزامی است")]
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (this.lastName != value)
                {
                    this.lastName = value;
                    this.OnPropertyChanged();
                }
            }
        }

        private string city;
        [DisplayOptions(Header = "شهر")]
        [NonEmptyValidator("شهر الزامی است")]
        public string City
        {
            get { return this.city; }
            set
            {
                if (this.city != value)
                {
                    this.city = value;
                    this.OnPropertyChanged();
                }
            }
        }

    }
}
