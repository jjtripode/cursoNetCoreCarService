using Microsoft.AspNetCore.Identity;

namespace CarServiceFronted.Models
{
    public class UsersViewModel
    {
        public User[] Users { get; set; }
        public AddNewUserViewModel AddNewUserViewModel { get;  set; }

        public AddNewUserViewModel GetAddNewUserViewModel()
        {
            return this.AddNewUserViewModel;
        }
        void ff()
        {
// Users[0].

        }
    }
}