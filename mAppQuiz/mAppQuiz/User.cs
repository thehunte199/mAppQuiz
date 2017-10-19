namespace mAppQuiz
{
    class User
    {
        public string _userName { get; set; }
        public string _pass { get; set; }

        public User(string userName, string pass)
        {
            _userName = userName;
            _pass = pass;
        }
    }
}
