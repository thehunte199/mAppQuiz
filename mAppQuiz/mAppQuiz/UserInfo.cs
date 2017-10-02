namespace mAppQuiz
{
    internal class UserInfo
    {
        public string FName;
        public string LName;
        public string Email;
        public string User;
        public string Pass;
       
        UserInfo(string fname, string lname, string email, string user, string pass)
        {
            this.FName = fname;
            this.LName = lname;
            this.Email = email;
            this.User = user;
            this.Pass = pass;
        }
    }
}