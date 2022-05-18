using FluentValidation.Results;
using System.Data;
using TestsGenerator.Domain.DisciplineModule;
using TestsGenerator.Domain.MateriaModule;
using TestsGenerator.Domain.QuestionModule;
using TestsGenerator.Domain.Shared;

namespace TestsGenerator.QuestionModule
{
    public partial class RegisterQuestionForm : Form
    {
        private Question question;
        private readonly List<Materia> _materias;
        public int corretas;

        public RegisterQuestionForm(List<Discipline> disciplines, List<Materia> materias)
        {
            InitializeComponent();

            _materias = materias;

            disciplines.ForEach(x => CbxDiscipline.Items.Add(x));
        }

        public Question Question
        {
            get { return question; }

            set
            {
                question = value;

                CbxDiscipline.SelectedItem = question.Discipline;
                CbxGrade.SelectedItem = question.Grade;
                CbxBimester.SelectedItem = question.Bimester;
                CbxMateria.SelectedItem = question.Materia;
                RTxbDescription.Text = question.Description;
                question.Alternatives.ForEach(x => ListAlternatives.Items.Add(x));
            }
        }

        public Func<Question, ValidationResult> SaveRecord { get; set; }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            question.Discipline = (Discipline)CbxDiscipline.SelectedItem;
            question.Grade = (string)CbxGrade.SelectedItem;

            if (CbxBimester.SelectedItem != null)
                question.Bimester = (Bimester)CbxBimester.SelectedItem;

            question.Materia = (Materia)CbxMateria.SelectedItem;
            question.Description = RTxbDescription.Text;

            foreach (Alternative item in ListAlternatives.Items)
            {
                if (question.Alternatives.Contains(item))
                    return;

                question.Alternatives.Add(item);
            }           

            ValidationResult validationResult = SaveRecord(question);

            if (validationResult.IsValid == false)
            {
                MessageBox.Show(validationResult.ToString("\n"), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                DialogResult = DialogResult.None;
            }
        }

        private void CbxDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbxGrade.Items.Clear();
            CbxBimester.Items.Clear();
            CbxMateria.Items.Clear();

            List<string> grades = _materias
                .Where(x => x.Discipline == (Discipline)CbxDiscipline.SelectedItem)
                .Select(y => y.Grade)
                .Distinct()
                .ToList();

            grades.ForEach(x => CbxGrade.Items.Add(x));
        }

        private void CbxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbxBimester.Items.Clear();
            CbxMateria.Items.Clear();

            List<Bimester> bimesters = Enum
                .GetValues(typeof(Bimester))
                .Cast<Bimester>()
                .ToList();

            bimesters.ForEach(x => CbxBimester.Items.Add(x));
        }

        private void CbxBimester_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbxMateria.Items.Clear();

            List<Materia> materias = _materias
                .Where(x =>
                x.Discipline == (Discipline)CbxDiscipline.SelectedItem &&
                x.Grade == (string)CbxGrade.SelectedItem &&
                x.Bimester == (Bimester)CbxBimester.SelectedItem)
                .ToList();

            materias.ForEach(x => CbxMateria.Items.Add(x));
        }

        private void CbxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            question.Materia = (Materia)CbxMateria.SelectedItem;
        }

        private void ListAlternatives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListAlternatives.SelectedItem is Alternative selectedItem)
            {
                TxbLetter.Text = selectedItem.Letter;
                ChbIsCorret.Checked = selectedItem.IsCorrect;
                TxbDescription.Text = selectedItem.Description;
            }
        }

        private void BtnAddAlternative_Click(object sender, EventArgs e)
        {
            if (ListAlternatives.SelectedItem != null)
                return;

            Alternative alternative = new(TxbLetter.Text, ChbIsCorret.Checked, TxbDescription.Text);
            
            AlternativeValidator alternativeValidator = new();

            ValidationResult validationResult = alternativeValidator.Validate(alternative);

            List<Alternative> alternativas = ListAlternatives.Items.Cast<Alternative>().ToList();
            List<bool> corretas = alternativas.Select(x => x.IsCorrect).ToList();

            if (corretas.Count >= 1 && ChbIsCorret.Checked == true)
            {
                validationResult.Errors.Add(new ValidationFailure("", "A questão não deve ter mais do que uma questão correta"));
            }

            if (validationResult.IsValid == false)
            {
                MessageBox.Show(validationResult.ToString("\n"), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ListAlternatives.Items.Add(alternative);

            ClearFields();
        }

        private void BtnEditAlternative_Click(object sender, EventArgs e)
        {
            if (ListAlternatives.SelectedItem is Alternative selectedItem)
            {
                selectedItem.Letter = TxbLetter.Text;
                selectedItem.IsCorrect = ChbIsCorret.Checked;
                selectedItem.Description = TxbDescription.Text;

                AlternativeValidator alternativeValidator = new();

                ValidationResult validationResult = alternativeValidator.Validate(selectedItem);

                List<Alternative> alternativas = ListAlternatives.Items.Cast<Alternative>().ToList();

                List<Alternative> corretas = alternativas.Where(x => x.IsCorrect == true).ToList();

                if (corretas.Count > 1 && ChbIsCorret.Checked == true)
                {
                    validationResult.Errors.Add(new ValidationFailure("", "A questão não deve ter mais do que uma questão correta"));
                }

                if (validationResult.IsValid == false)
                {
                    ChbIsCorret.Checked = false;
                    selectedItem.IsCorrect = ChbIsCorret.Checked;
                    alternativas.Clear();
                    corretas.Clear();
                    MessageBox.Show(validationResult.ToString("\n"), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                alternativas.Clear();
                corretas.Clear();

                int index = ListAlternatives.SelectedIndex;

                ListAlternatives.Items.RemoveAt(index);
                ListAlternatives.Items.Insert(index, selectedItem); 
            }

            ClearFields();
            ListAlternatives.ClearSelected();
        }

        private void BtnDeleteAlternative_Click(object sender, EventArgs e)
        {
            if (ListAlternatives.SelectedItem is Alternative)
            {
                int index = ListAlternatives.SelectedIndex;

                ClearFields();
                ListAlternatives.Items.RemoveAt(index);
            }
        }

        private void ClearFields()
        {
            TxbLetter.Clear();
            ChbIsCorret.Checked = false;
            TxbDescription.Clear();
        }
    }
}