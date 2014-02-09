using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace HashGag.Models.ViewModels
{
    public class HubViewModel
    {
        private const string welcomeString = "Welcome {0} to HashGag. Please select a Question to participate in.";
        public string WelcomeMessage;
        public List<Question> ColumnOneQuestions;
        public List<Question> ColumnTwoQuestions;
        public List<Question> ColumnThreeQuestions;

        public HubViewModel(string user, List<Question> columnOneQuestions, List<Question> columnTwoQuestions, List<Question> columnThreeQuestions)
        {
            if (!user.IsNullOrWhiteSpace())
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendFormat(welcomeString, user);
                WelcomeMessage = builder.ToString();
            }
            else WelcomeMessage = string.Empty;
            
            ColumnOneQuestions = columnOneQuestions;
            ColumnTwoQuestions = columnTwoQuestions;
            ColumnThreeQuestions = columnThreeQuestions;
        }
    }
}