namespace mAppQuiz.Data
{
    class User
    {
        public string UserName { get; set; }
        public string Pass { get; set; }

        public User(string userName, string pass)
        {
            UserName = userName;
            Pass = pass;
        }
    }
}
