using System.IO;

namespace E_JOGOS.Models{
    public class EjogosBase
    {
        //funcao para criar a pasta e o arquivo
        //string path é o parametro da funcao, que tera o caminho 
        //para analise.
        public void CreateFolderAndFile(string path) {
            // pasta / arquivo.csv;
            string folder = path.Split('/')[0];//recebe nome da pasta
            string file = path.Split('/')[1];//recebe nome do arquivo
            if (!Directory.Exists(folder)) { 
                Directory.CreateDirectory(folder);
            }
            if (!File.Exists(path) ){
                var f = File.Create(path);
                f.Close();
                //correçao
            }
            
            Directory.CreateDirectory(folder);  

        }
    }
}
