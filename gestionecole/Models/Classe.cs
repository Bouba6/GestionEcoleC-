using gestionecole.Enum;

namespace gestionecole.Models
{
    public class Classe : AbstractEntity
    {
        public int Id { get; set; }

        public string libelle { get; set; }

        public Filere niveau { get; set; }

        public List<Cours>? detailCours { get; set; } = new List<Cours>();
    }
}