namespace QA.Framework.Core.Data
{
    using Templates;

    public static class TestUsers
    {
        public static User TestUser1 { get; set; }
        public static User TestUser2 { get; set; }
        public static User Admin { get; set; }
        public static User TestRegistrationUser { get; set; }

        static TestUsers()
        {
            TestRegistrationUser = new User { Username = "Test", Password = "123456", FirstNameInBulgarian = "Тестово-Име", LastNameInBulgarian = "Тестова-Фамилия" , Email = "@test.com"};
            TestUser1 = new User { Username = "usersModuleFrontTest", Password = "123456", ProfileUrl = "http://test.telerikacademy.com/Users/usersModuleFrontTest" };
            TestUser2 = new User { Username = "usersModuleFrontTest2", Password = "123456", ProfileUrl = "http://test.telerikacademy.com/Users/usersModuleFrontTest2" };
            Admin = new User { Username = "administrator", Password = "adminpassword" };
        }
    }
}
