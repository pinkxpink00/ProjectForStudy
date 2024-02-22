using ProjectForStudy.Models;

namespace ProjectForStudy.Components.Pages
{
    public partial class Home
    {

        private List<Contact> contacts;

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(5000);

            contacts = new List<Contact>
            {
            new Contact
            {
                FirstName = "German",
                LastName = "Gritsenko2",
                Email = "SomeEmail2@gmail.com",
                Phone = "123123"
            },
            new Contact
            {
                FirstName = "German",
                LastName = "Gritsenko1",
                Email = "SomeEmail1@gmail.com",
                Phone = "123123"
            },
            new Contact
            {
                FirstName = "German",
                LastName = "Gritsenko3",
                Email = "SomeEmail3@gmail.com",
                Phone = "123123"
            }
            };

            base.OnInitializedAsync();
        }
    }
}
