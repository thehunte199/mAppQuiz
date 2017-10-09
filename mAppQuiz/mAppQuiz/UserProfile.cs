namespace mAppQuiz
{
    internal class UserProfile
    {
        public string _fName { get; set; }
        public string _lName { get; set; }
        public string _email { get; set; }
        public string _userName { get; set; }
        public string _pass { get; set; }

        public UserProfile(string fname, string lname, string email, User user)
        {
            this._userName = user._userName;
            this._pass = user._pass;
            this._fName = fname;
            this._lName = lname;
            this._email = email;
        }


    }
}
