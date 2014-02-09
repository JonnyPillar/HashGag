using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HashGag.Models.ViewModels
{
    public class HubViewModel
    {
        public List<Question> ColumnOneQuestions;
        public List<Question> ColumnTwoQuestions;
        public List<Question> ColumnThreeQuestions;

        public HubViewModel(List<Question> columnOneQuestions, List<Question> columnTwoQuestions, List<Question> columnThreeQuestions)
        {
            ColumnOneQuestions = columnOneQuestions;
            ColumnTwoQuestions = columnTwoQuestions;
            ColumnThreeQuestions = columnThreeQuestions;
        }
    }
}