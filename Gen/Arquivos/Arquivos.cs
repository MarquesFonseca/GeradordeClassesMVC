using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;

namespace GeradorClasses
{
    /// <summary>
    /// Esta classe é utilizada para manipular arquivos
    /// podendo copiar, excluir, renomear, checar existencia...
    /// entre outras ações.
    /// </summary>
    public static class Arquivos
    {
        public static ArrayList LerArquivo(string Arquivo)
        {
            ArrayList Retorno = new ArrayList();

            FileInfo _arquivo = new FileInfo(Arquivo);

            using (StreamReader linha = new StreamReader(_arquivo.FullName, Encoding.UTF8))
            {
                string Linha;

                while (!linha.EndOfStream)
                {
                    Linha = linha.ReadLine();
                    Retorno.Add(Linha);
                }
            }

            return Retorno;

        }

        /// <summary>
        /// Metodo para saber se o arquivo ou um diretório existe
        /// </summary>
        /// <param name="Arquivo">Informe o caminho do arquivo ou do diretório que deseja verificar</param>
        /// <example>Existe("C:\\Log\\Teste.TXT");</example>
        /// <returns>Se o arquivo existir retorna TRUE, senão retorna FALSE</returns>
        public static bool Existe(string Arquivo, bool Diretorio)
        {
            if (Diretorio)
            {
                if (System.IO.Directory.Exists(Arquivo))
                    return true;
                else
                    return false;
            }
            if (File.Exists(Arquivo))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Metodo para deletar arquivo
        /// </summary>
        /// <param name="RaizDiretorio">Informe a raiz do arquivo</param>
        /// <param name="CaminhoArquivo">Informe o caminho do arquivo</param>
        /// <example>DeletarArquivo("C:\\","TESTE\\TESTE.TXT");</example>
        /// <returns>Se operação realizada com sucesso, retorna TRUE, senão Retorna FALSE</returns>
        public static bool DeletarArquivo(string RaizDiretorio, string CaminhoArquivo)
        {
            try
            {
                FileInfo Arquivo = new FileInfo(CaminhoArquivo);
                DirectoryInfo DiretorioArquivo = new DirectoryInfo(RaizDiretorio);
                if (DiretorioArquivo.Exists)
                {
                    Arquivo.Delete();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Carrega o arquivo do disco byte a byte.
        /// </summary>
        /// <param name="caminhoOrigem">Informe o caminho do arquivo a ser carregado</param>
        /// <returns>Retorna o arquivo carregado do disco</returns>
        public static byte[] CarregarArquivo(string CaminhoOrigem)
        {
            byte[] Dados = null;
            FileInfo Arquivo = new FileInfo(CaminhoOrigem);
            long Bytes = Arquivo.Length;
            FileStream fStream = new FileStream(CaminhoOrigem, FileMode.Open, FileAccess.Read);
            BinaryReader bReader = new BinaryReader(fStream);
            Dados = bReader.ReadBytes((int)Bytes);
            fStream.Close();
            return Dados;
        }

        /// <summary>
        /// Copia arquivo de um diretorio para outro, substituindo o arquivo existente
        /// </summary>
        /// <param name="Origem">Informe o diretorio de origem</param>
        /// <param name="Destino">Informe o diretorio de destino</param>
        /// <param name="NomeArquivo">Informe o nome do arquivo a ser copiado</param>
        public static void CopiarArquivo(string Origem, string Destino, string NomeArquivo)
        {
            string Arquivo = NomeArquivo;

            // Crie uma nova pasta de estino, se necessario.
            CriarDiretorio(Destino);

            //verifica se o diretorio de destino existe
            if (System.IO.Directory.Exists(Destino))
            {
                string ArquivoOrigem = System.IO.Path.Combine(Origem, Arquivo);
                string ArquivoDestino = System.IO.Path.Combine(Destino, Arquivo);

                //Para copiar um ariquivo para outro local e sobrescrever o existente
                System.IO.File.Copy(ArquivoOrigem, ArquivoDestino, true);
            }
        }

        /// <summary>
        /// Metodo para criar diretório
        /// </summary>
        /// <param name="Destino">Passe o caminho do diretório que deseja criar</param>
        public static void CriarDiretorio(string Destino)
        {
            //se não existir o diretório será criado
            if (!System.IO.Directory.Exists(Destino))
            {
                System.IO.Directory.CreateDirectory(Destino);
                //return "Diretório criado com sucesso!";
            }
            else
            {
                //return "Diretório já existe!";
            }
        }

        /// <summary>
        /// metodo para excluir arquivo
        /// </summary>
        /// <param name="Origem">informe o caminho do arquivo com o arquivo</param>
        /// <example>ExcluirArquivo(@"C:\SISTEMA\TESTE.TXT");</example>
        public static void ExcluirArquivo(string Origem)
        {
            if (Existe(Origem, false))
            {
                System.IO.File.Delete(Origem);
            }

            #region Deletar
            // ...or by using FileInfo instance method.
            //System.IO.FileInfo fi = new System.IO.FileInfo(@"C:\Users\Public\DeleteTest\test2.txt");
            //try
            //{
            //    fi.Delete();
            //}
            //catch (System.IO.IOException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            // Delete a directory. Must be writable or empty.
            //try
            //{
            //    System.IO.Directory.Delete(Origem);
            //}
            //catch (System.IO.IOException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //// Delete a directory and all subdirectories with Directory static method...
            //if (System.IO.Directory.Exists(Origem))
            //{
            //    try
            //    {
            //        System.IO.Directory.Delete(Origem, true);
            //    }

            //    catch (System.IO.IOException e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //}

            //// ...or with DirectoryInfo instance method.
            //System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Origem);
            //// Delete this dir and all subdirs.
            //try
            //{
            //    di.Delete(true);
            //}
            //catch (System.IO.IOException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            #endregion
        }

        /// <summary>
        /// Metodo para excluir um diretorio que esteja vazio
        /// </summary>
        /// <param name="Origem">Informe o caminho do diretorio que deseja excluir</param>
        /// <example>ExcluirDiretorioVazio(@"C:\SISTEMA\TESTE");</example>
        public static void ExcluirDiretorioVazio(string Origem)
        {
            try
            {
                System.IO.Directory.Delete(Origem);
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        /// <summary>
        /// Metodo para excluir diretório e subdiretórios
        /// </summary>
        /// <param name="Origem">Informe o caminho do diretório que deseja excluir</param>
        /// <example>ExcluirDiretorioESubDiretorios(@"C:\SISTEMA\TESTE");</example>
        public static void ExcluirDiretorioESubDiretorios(string Origem)
        {
            if (Existe(Origem, true))
            {
                try
                {
                    System.IO.Directory.Delete(Origem, true);
                }

                catch (System.IO.IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// Chama um arquivo passado por parametro
        /// </summary>
        /// <param name="Origem">Arquivo a ser execultado</param>
        public static void ExecultarArquivo(string Origem)
        {
            if (Existe(Origem, false))
                Process.Start(Origem);
        }

        /// <summary>
        /// Chama um arquivo passado por parametro
        /// </summary>
        /// <param name="Origem">Arquivo a ser execultado</param>
        public static void ExecultarArquivo(string Origem, string Args)
        {
            if (Existe(Origem, false))
                Process.Start(Origem, Args);
        }

        /// <summary>
        /// Metodo para renomear um arquivo
        /// </summary>
        /// <param name="NomeAntigo">Informe o caminho juntamente com o antigo nome do arquivo</param>
        /// <param name="NomeNovo">Informe o caminho juntamente com o novo nome do artivo</param>
        public static void RenomearArquivo(string NomeAntigo, string NomeNovo)
        {
            // vamos renomear o arquivo
            if (Existe(NomeAntigo, false))
                if (!Existe(NomeNovo, false))
                    File.Move(NomeAntigo, NomeNovo);
        }

        /// <summary>
        /// Metodo utilizado para mover arquivos de um diretório para outro
        /// </summary>
        /// <param name="Origem">Informe o caminho de origem juntamente com o nome do arquivo</param>
        /// <param name="Destino">Informe o caminho de destino juntamente com o nome do arquivo</param>
        public static void MoverArquivo(string Origem, string Destino)
        {
            RenomearArquivo(Origem, Destino);
        }

        public static void CriarArquivo(string caminho, string nomeArquivo, string extensao, object conteudo)
        {
            try
            {
                
                if (!caminho.Substring(caminho.Length - 1, 0).Contains("\\"))
                    caminho = caminho + "\\";

                if (!Existe(caminho, true))
                    CriarDiretorio(caminho);

                //arquivo passando como parâmetro a variável strPathFile, que contém o arquivo
                using (FileStream fs = File.Create(string.Format("{0}{1}.{2}", caminho, nomeArquivo, extensao)))
                {
                    //como parâmetro a variável fs, referente ao FileStream criado anteriormente
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                    {
                        //método Write para escrever algo em nosso arquivo
                        sw.Write(conteudo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

