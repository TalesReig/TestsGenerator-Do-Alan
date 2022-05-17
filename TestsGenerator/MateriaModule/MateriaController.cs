using TestsGenerator.Domain.MateriaModule;
using TestsGenerator.Infra.DisciplineModule;
using TestsGenerator.Infra.MateriaModule;
using TestsGenerator.Shared;

namespace TestsGenerator.MateriaModule
{
    public class MateriaController : BaseController
    {
        private readonly MateriaRepository _materiaRepository;
        private readonly DisciplineRepository _disciplineRepository;

        private readonly MateriaControl materiaControl;

        public MateriaController(MateriaRepository materiaRepository, DisciplineRepository disciplineRepository)
        {
            _materiaRepository = materiaRepository;
            _disciplineRepository = disciplineRepository;
            materiaControl = new(this);
        }

        public override void Insert()
        {
            RegisterMateriaForm screen = new(_disciplineRepository.GetRegisters());

            screen.Materia = new();
            screen.SaveRecord = _materiaRepository.Insert;

            DialogResult dialogResult = screen.ShowDialog();

            if (dialogResult == DialogResult.OK) 
                LoadMaterias();
        }

        public override void Update()
        {
            Materia selectedMateria = GetMateria();

            if (selectedMateria == null)
            {
                MessageBox.Show("Selecione uma matéria primeiro.", "Edição de Matéria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RegisterMateriaForm screen = new(_disciplineRepository.GetRegisters());

            screen.Text = "Editando Matéria";

            screen.Materia = selectedMateria;
            screen.SaveRecord = _materiaRepository.Update;

            DialogResult dialogResult = screen.ShowDialog();

            if (dialogResult == DialogResult.OK)
                LoadMaterias();
        }

        public override void Delete()
        {
            Materia selectedMateria = GetMateria();

            if (selectedMateria == null)
            {
                MessageBox.Show("Selecione uma matéria primeiro.", "Exclusão de Matéria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir este registro?", "Exclusão de Matéria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                _materiaRepository.Delete(selectedMateria);
                LoadMaterias();
            }
        }

        public override UserControl GetControl()
        {
            LoadMaterias();

            return materiaControl;
        }

        private void LoadMaterias()
        {
            List<Materia> materias = _materiaRepository.GetRegisters();

            materiaControl.UpdateGrid(materias);
        }

        private Materia GetMateria()
        {
            if (materiaControl.GetGrid().CurrentCell != null && materiaControl.GetGrid().CurrentCell.Selected == true)
            {
                int index = materiaControl.GetSelectedRow();
                return _materiaRepository.GetByIndex(index);   
            }

            return null;
        }
    }
}