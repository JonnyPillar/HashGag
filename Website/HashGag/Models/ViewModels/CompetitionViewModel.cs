using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HashGag.Models.ViewModels
{
    public class CompetitionViewModel
    {
        public List<CompTweetModel> ColumnOneQuestions;
        public List<CompTweetModel> ColumnTwoQuestions;
        public List<CompTweetModel> ColumnThreeQuestions;

        public CompetitionViewModel(List<CompTweetModel> columnOneQuestions, List<CompTweetModel> columnTwoQuestions, List<CompTweetModel> columnThreeQuestions)
        {
            ColumnOneQuestions = columnOneQuestions;
            ColumnTwoQuestions = columnTwoQuestions;
            ColumnThreeQuestions = columnThreeQuestions;
        }
    }
}