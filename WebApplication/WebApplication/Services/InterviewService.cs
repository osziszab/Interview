using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Data;
using WebApplication.Entities;

namespace WebApplication.Services
{
    public class InterviewService
    {
        private readonly ApplicationContext interviewContext;

        public InterviewService(ApplicationContext interviewContext)
        {
            this.interviewContext = interviewContext;
        }

        public List<Test> GetTenTestsFromFixDate()
        {
            DateTime fixDate = new DateTime(2017, 04, 28);
            List<Test> result = interviewContext.Tests.Where(x => x.SignupDate > fixDate).OrderBy(x => x).Take(10).ToList();
            if (result == null)
                throw new NullReferenceException("No dates");
            return result;
        }

        public string CharacterDivider(string input)
        {
            if (input != null)
            {

                StringBuilder result = new StringBuilder();
                var textArray = input.ToCharArray();
                foreach (var letter in textArray)
                {
                    result.Append(letter);
                    result.Append("_");
                }
                return result.ToString();
            }
            else
            {
                throw new NullReferenceException("Given text is empty");
            }
        }
    }
}
