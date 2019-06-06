using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kreator.Model;
namespace Kreator.QuestionControl {
    class QuestionItemPresenter : IPresenter, IQuestionItemPresenter {
        IQuestionItem view;
        readonly TestModel model;
        public QuestionItemPresenter(IQuestionItem control) {
            this.view = control;
            this.model = TestModel.Instance;
        }
        public void ClearQuestionItem() {
            this.view.ClearAnswerContainer();
            this.view.ClearQuestionContent();
        }

        public void SaveQuestion() {
            Question question = new Question {
                Content = this.view.Content
            };
            foreach (var item in this.view.Answers) {
                Answer answer = new Answer {
                    Content = item.AnswerContent,
                    Points = item.Points
                };
                question.Answers.Add(answer);
            }

            this.model.TestItem.Questions.Add(question);

            ClearQuestionItem();


        }
        
        public bool validateData() {

            if (!view.Content.Equals("")) {
                foreach(var item in this.view.Answers) {
                    if(item.AnswerContent.Equals("") && item.Points == 0) {
                        MessageBox.Show("Uzupełnij wszystkie pola odpowiedzi");
                        return false;
                    }
                   
                }
                return true;

            } else {
                MessageBox.Show("Uzupełnij treść pytania");
                return false;
            }
        }
    }
}
