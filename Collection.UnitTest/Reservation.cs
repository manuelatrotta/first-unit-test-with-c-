namespace Collection.UnitTest
{
    internal class Reservation
    {
        public User MadeBy { get; set; }

        public bool CancelledBy(User user)
        {
            if (user.IsAdmin)
            {
                return true;
            }

            if (MadeBy == user)
            {
                return true;
            }
            else { return false; }
        }
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}
