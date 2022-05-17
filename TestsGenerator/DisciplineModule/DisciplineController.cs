using TestsGenerator.Domain.DisciplineModule;
using TestsGenerator.Infra.DisciplineModule;
using TestsGenerator.Shared;

namespace TestsGenerator.DisciplineModule
{
    public class DisciplineController : BaseController
    {
        private readonly DisciplineRepository _disciplineRepository;
        private readonly DisciplineControl disciplineControl;

        public DisciplineController(DisciplineRepository disciplineRepository)
        {
            _disciplineRepository = disciplineRepository;
            disciplineControl = new(this);
        }

        public override void Insert()
        {
            RegisterDisciplineForm screen = new();

            screen.Discipline = new();
            screen.SaveRecord = _disciplineRepository.Insert;

            DialogResult dialogResult = screen.ShowDialog();

            if (dialogResult == DialogResult.OK)
                LoadDisciplines();
        }

        public override void Update()
        {
            Discipline selectedDiscipline = GetDiscipline();

            if (selectedDiscipline == null)
            {
                MessageBox.Show("Selecione uma disciplina primeiro.", "Edição de Disciplina", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RegisterDisciplineForm screen = new();

            screen.Text = "Editando Disciplina";

            screen.Discipline = selectedDiscipline.Clone();
            screen.SaveRecord = _disciplineRepository.Update;

            DialogResult dialogResult = screen.ShowDialog();

            //if (dialogResult == DialogResult.OK)
                LoadDisciplines();
        }

        public override void Delete()
        {
            Discipline selectedDiscipline = GetDiscipline();

            if (selectedDiscipline == null)
            {
                MessageBox.Show("Selecione uma disciplina primeiro.", "Exclusão de Disciplina", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir este registro?", "Exclusão de Disciplina", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                _disciplineRepository.Delete(selectedDiscipline);
                LoadDisciplines();
            }
        }

        public override UserControl GetControl()
        { 
            LoadDisciplines();

            return disciplineControl;
        }

        private void LoadDisciplines()
        {
            List<Discipline> disciplines = _disciplineRepository.GetRegisters();

            disciplineControl.UpdateGrid(disciplines);
        }

        private Discipline GetDiscipline()
        {
            if (disciplineControl.GetGrid().CurrentCell != null && disciplineControl.GetGrid().CurrentCell.Selected == true)
            {
                int index = disciplineControl.GetSelectedRow();
                return _disciplineRepository.GetByIndex(index);
            }

            return null;
        }
    }
}