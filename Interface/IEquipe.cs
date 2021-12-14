using System.Collections.Generic;

namespace E_JOGOS.Interface
{
    /// <summary>
    /// Responsavel por determinar quais metodos uma classe terá
    /// </summary>
    public interface IEquipe
    {

        //Create
        //ReadAll
        //Update
        //Delete

        void Create(Models.Equipe NovaEquipe);
        List<Models.Equipe> ReadAll();

        void Update(Models.Equipe NovaEquipe);

        void Delete(int IdEquipe);
    }
}
