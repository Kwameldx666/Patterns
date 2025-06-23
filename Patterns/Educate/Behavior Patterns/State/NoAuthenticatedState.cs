namespace Patterns.Educate.Behavior_Patterns.State
{
    internal class NoAuthenticatedState : IUserState
    {
        private readonly UserService _userService;
        public NoAuthenticatedState(UserService userService)
        {
            _userService = userService;
        }
        public void Auth()
        {
            Console.WriteLine("Write password and name");
            var data = Console.ReadLine();
            if (data == "admin")
            {
                Console.WriteLine("You are authenticated");
                _userService.SetState(new AuthenticatedState(_userService));
            }
            else
            {
                Console.WriteLine("You are not authenticated, try again");
            }
        }

        public void BuyProduct(string product)
        {
            Console.WriteLine("" + product);
        }

        public void TryToScam()
        {
            Console.WriteLine("You can't anymore to scam");
        }
    }
}