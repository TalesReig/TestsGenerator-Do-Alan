using TestsGenerator.Domain.QuestionModule;
using TestsGenerator.Infra.DisciplineModule;
using TestsGenerator.Infra.MateriaModule;
using TestsGenerator.Infra.QuestionModule;
using TestsGenerator.Shared;

namespace TestsGenerator.QuestionModule
{
    public class QuestionController : BaseController
    {
        private readonly QuestionRepository _questionRepository;
        private readonly MateriaRepository _materiaRepository;
        private readonly DisciplineRepository _disciplineRepository;

        private readonly QuestionControl questionControl;

        public QuestionController(QuestionRepository questionRepository, MateriaRepository materiaRepository, DisciplineRepository disciplineRepository)
        {
            _questionRepository = questionRepository;
            _materiaRepository = materiaRepository;
            _disciplineRepository = disciplineRepository;
            questionControl = new(this);
        }

        public override void Insert()
        {
            RegisterQuestionForm screen = new(_disciplineRepository.GetRegisters(), _materiaRepository.GetRegisters());

            screen.Question = new();
            screen.SaveRecord = _questionRepository.Insert;

            DialogResult dialogResult = screen.ShowDialog();

            if (dialogResult == DialogResult.OK)
                LoadQuestions();
        }

        public override void Update()
        {
            Question selectedQuestion = GetQuestion();

            if (selectedQuestion == null)
            {
                MessageBox.Show("Selecione uma questão primeiro.", "Edição de Questão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RegisterQuestionForm screen = new(_disciplineRepository.GetRegisters(), _materiaRepository.GetRegisters());

            screen.Text = "Editando Questão";

            screen.Question = selectedQuestion;
            screen.SaveRecord = _questionRepository.Update;

            DialogResult dialogResult = screen.ShowDialog();

            if (dialogResult == DialogResult.OK)
                LoadQuestions();
        }

        public override void Delete()
        {
            Question selectedQuestion = GetQuestion();

            if (selectedQuestion == null)
            {
                MessageBox.Show("Selecione uma questão primeiro.", "Exclusão de Questão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir este registro?", "Exclusão de Questão", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                _questionRepository.Delete(selectedQuestion);
                LoadQuestions();
            }
        }

        public override UserControl GetControl()
        {
            LoadQuestions();

            return questionControl;
        }

        private void LoadQuestions()
        {
            List<Question> questions = _questionRepository.GetRegisters();

            questionControl.UpdateGrid(questions);
        }

        private Question GetQuestion()
        {
            if (questionControl.GetGrid().CurrentCell != null && questionControl.GetGrid().CurrentCell.Selected == true)
            {
                int index = questionControl.GetSelectedRow();
                return _questionRepository.GetByIndex(index);
            }

            return null;
        }
    }
}