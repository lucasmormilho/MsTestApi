namespace TesterAPITestUnitarioSozinho
{
    [TestClass]
    public class UserControllerTest
    {
        UserController controller;

        [TestMethod]
        public void Post_Test_OK()
        {
            var responseAPI = controller.Post();
        }
    }
}