using System.Collections.Generic;

namespace WebApplication1.Logic
{
    public class Equipe
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        public ICollection<Programmeur> Programmeurs { get; set; }
    }
}