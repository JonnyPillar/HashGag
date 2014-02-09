using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HashGag.Models.ViewModels
{
    public class CompetitionViewModel
    {
        public List<Question> ColumnOneQuestions;
        public List<Question> ColumnTwoQuestions;
        public List<Question> ColumnThreeQuestions;

        public CompetitionViewModel(List<Question> columnOneQuestions, List<Question> columnTwoQuestions, List<Question> columnThreeQuestions)
        {
            ColumnOneQuestions = columnOneQuestions;
            ColumnTwoQuestions = columnTwoQuestions;
            ColumnThreeQuestions = columnThreeQuestions;
        }
    }
}