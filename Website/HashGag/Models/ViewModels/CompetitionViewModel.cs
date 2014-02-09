using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HashGag.Models.ViewModels
{
    public class CompetitionViewModel
    {
        public List<Tweet> ColumnOneQuestions;
        public List<Tweet> ColumnTwoQuestions;
        public List<Tweet> ColumnThreeQuestions;

        public CompetitionViewModel(List<Tweet> columnOneQuestions, List<Tweet> columnTwoQuestions, List<Tweet> columnThreeQuestions)
        {
            ColumnOneQuestions = columnOneQuestions;
            ColumnTwoQuestions = columnTwoQuestions;
            ColumnThreeQuestions = columnThreeQuestions;
        }
    }
}