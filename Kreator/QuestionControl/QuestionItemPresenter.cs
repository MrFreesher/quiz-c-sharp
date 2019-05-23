using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kreator.Model;
namespace Kreator.QuestionControl {
    class QuestionItemPresenter : IPresenter, IQuestionItemPresenter {
        IQuestionItem view;
        TestModel model;
        public QuestionItemPresenter(IQuestionItem control) {
            this.view = control;
            this.model = TestModel.Instance;
        }
        public void ClearQuestionItem() {
            this.view.ClearAnswerContainer();
            this.view.ClearQuestionContent();
        }

        public void SaveQuestion() {
            Question q = new Question();
            q.Content = this.view.Content;
            foreach (var item in this.view.Answers) {
                Answer answer = new Answer {
                    Content = item.AnswerContent,
                    Points = item.Points
                };
                q.Answers.Add(answer);
            }

            this.model.TestItem.Questions.Add(q);

            ClearQuestionItem();


        }
    }
}
