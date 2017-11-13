namespace mAppQuiz.Data
{
    internal class UserProfile
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }

        public UserProfile(string fname, string lname, string email, User user)
        {
            UserName = user.UserName;
            Pass = user.Pass;
            FName = fname;
            LName = lname;
            Email = email;
        }


    }
}
