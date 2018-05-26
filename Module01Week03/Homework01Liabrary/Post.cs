using System;
using System.Collections.Generic;
using System.Text;

namespace Homework01Liabrary
{
    class Post
    {
        private DateTime postDate;
        private string content;
        private Account userName;

        public Post(DateTime postDate, string content, Account userName)
        {
            this.postDate = postDate;
            this.content = content;
            this.userName = userName;
        }
    }
}
