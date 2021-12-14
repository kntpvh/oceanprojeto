using System.Collections.Generic;
using System.IO;

namespace E_JOGOS.Models
{
    public class Equipe : EjogosBase,Interface.IEquipe
    {
        private const string path = "Database/equipe.csv";
        public Equipe()
        {
            CreateFolderAndFile(path);
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        // funcao que vai preparar/converter de string para tipo equipe.

        public void Create(Equipe NovaEquipe)
        {
            //receber um objeto de equipe
            //gravar no csv
            string[] equipeCadastrar = { $"{NovaEquipe.Id};{NovaEquipe.Nome};{NovaEquipe.Imagem};" };
            //string[] cadastro = new string [1];
            //cadastro[0] = equipeCadastrar;
            //var f = File.OpenRead(path);
            //f = File.AppendAllLines(path, equipeCadastrar);
            //f.Close();
            //File.AppendAllLinesAsync(path, equipeCadastrar, default);
            File.AppendAllLines(path, equipeCadastrar);
            
            
            //File.Clo
            //throw new System.NotImplementedException();
        }

        public void Delete(int IdEquipe)
        {
            throw new System.NotImplementedException();
        }

        public List<Equipe> ReadAll()
        {
            List<Models.Equipe> equipes = new List<Models.Equipe>();
            string[] linhas = File.ReadAllLines(path);

            foreach (string item in linhas)
            {
                Models.Equipe equipe = new Equipe();
                equipe.Id = int.Parse(item.Split(';')[0]);
                equipe.Nome = item.Split(';')[1];
                equipe.Imagem = item.Split(';')[2];

                equipes.Add(equipe);
            }
            return equipes;
        }

        public void Update(Equipe NovaEquipe)
        {
            throw new System.NotImplementedException();
        }
    }
}
