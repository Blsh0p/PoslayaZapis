using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp2.Tests
{
    [TestClass]
    public class PolskayaZapis
    {
        private readonly string databaseFilePath = "Data Source=WindowsFormsApp2"; 

        [TestMethod]
        public void TestBD()
        {
            Database database = new Database(databaseFilePath);
            bool result = database.InitializeDatabase();
            Assert.IsTrue(result);

            
        }

        

        [TestMethod]
        public void TestRegisterUser()
        {
            Database database = new Database(databaseFilePath);
            bool registrationResult = database.RegisterUser("login", "password", "role");
            Assert.IsTrue(registrationResult);

            
        }

        [TestMethod]
        public void TestUserLogin()
        {
            // Arrange
            Database database = new Database(databaseFilePath);
            string testLogin = "testUser";
            string testPassword = "testPassword";

            // Ensure the test user is registered
            database.RegisterUser(testLogin, testPassword, "user");

            // Act
            bool loginResult = database.UserExists(testLogin, testPassword);

            // Assert
            Assert.IsTrue(loginResult, "User login failed.");
        }

        [TestMethod]
        public void TestPolNot()
        {
            string infixExpression = "a+b*c";
            string expectedPrefix = "+a*bc";
            Form3 form = new Form3();           
            string actualPrefix = form.PolNot(infixExpression);          
            Assert.AreEqual(expectedPrefix, actualPrefix);
        }
    }
}