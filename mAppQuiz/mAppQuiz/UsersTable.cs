using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mAppQuiz
{
    [DynamoDBTable("users")]
    class UsersTable
    {
        [DynamoDBHashKey]    // Hash key.
        public string username { get; set; }
        public string password { get; set; }
    }
}
