using System;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Configuracao
{
    /// <summary>
    /// Classe com valores de configuração do sistema
    /// </summary>
    public class Configs : IDisposable
    {
        static Configs()
        {
            conf = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
        }

        public static Configuration conf;

        ///// <summary>
        ///// Grava o valor de uma configuração no arquivo app.config
        ///// </summary>
        ///// <param name="Chave"></param>
        ///// <param name="Valor"></param>
        //public static void GravaConfig(string Chave, string Valor)
        //{
        //    try
        //    {
        //        conf.AppSettings.Settings[Chave].Value = Valor;
        //        conf.Save();
        //    }
        //    catch
        //    {
        //        conf.AppSettings.Settings.Add(Chave, Valor);
        //        conf.Save();
        //    }
        //}
        
        ///// <summary>
        ///// Retorna o valor de uma configuração do arquivo app.conf
        ///// </summary>
        ///// <param name="Chave">Chave que contém o valor</param>
        ///// <returns>Valor gravado no arquivo app.config</returns>
        //public static string RetornaConfig(string Chave, string DefaultValue)
        //{
        //    try
        //    {
        //        return conf.AppSettings.Settings[Chave].Value;
        //    }
        //    catch
        //    {
        //        conf.AppSettings.Settings.Add(Chave, DefaultValue);
        //        conf.Save();
        //        return DefaultValue;
        //    }
        //}

        /// <summary>
        /// Grava o valor de uma configuração no arquivo app.config
        /// </summary>
        /// <param name="chave"></param>
        /// <param name="valor"></param>
        public static void GravaConfig(string chave, string valor)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            KeyValueConfigurationCollection settings = config.AppSettings.Settings;

            try
            {
                bool existeChave = false;
                if (settings.AllKeys.Any(nomeChaveAtual => nomeChaveAtual == chave))
                {
                    existeChave = true;
                    // update SaveBeforeExit
                    settings[chave].Value = valor;
                }

                if (!existeChave)
                {
                    settings.Add(chave, valor);
                }

                //save the file
                config.Save(ConfigurationSaveMode.Modified);

                //relaod the section you modified
                ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            }
            catch
            {
                return;
            }
        }

        /// <summary>
        /// Retorna o valor de uma configuração do arquivo app.conf
        /// </summary>
        /// <param name="chave">Chave que contém o valor</param>
        /// <returns>Valor gravado no arquivo app.config</returns>
        public static string RetornaConfig(string chave, string DefaultValue)
        {
            string retorno = string.Empty;
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            KeyValueConfigurationCollection settings = config.AppSettings.Settings;

            try
            {
                if (settings.AllKeys.Any(nomeChaveAtual => nomeChaveAtual == chave))
                {
                    retorno = settings[chave].Value.ToString(CultureInfo.InvariantCulture);
                    return retorno;
                }

                //Caso a chave não exista, cria uma nova e retorna vazio
                settings.Add(chave, "");

                //save the file
                config.Save(ConfigurationSaveMode.Modified);

                //relaod the section you modified
                ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);

                return DefaultValue;
            }
            catch
            {
                return DefaultValue;
            }
        }

        public static System.Drawing.Size StringToSize(string _Size)
        {
            string[] Tamanhos = _Size.Replace("{", string.Empty).Replace("}", string.Empty).ToUpper().Trim().Split(',');
            int Width = 0, Height = 0;
            string Val = string.Empty;

            try
            {
                Val = Tamanhos.ToList().Where(T => T.ToUpper().Contains("WIDTH")).First();
                Width = Convert.ToInt32(Val.Substring(Val.IndexOf("=") + 1));

                Val = Tamanhos.ToList().Where(T => T.ToUpper().Contains("HEIGHT")).First();
                Height = Convert.ToInt32(Val.Substring(Val.IndexOf("=") + 1));
            }
            catch { }

            return new System.Drawing.Size(Width, Height);
        }

        public static System.Drawing.Point StringToPoint(string _Size)
        {
            string[] Tamanhos = _Size.Replace("{", string.Empty).Replace("}", string.Empty).ToUpper().Trim().Split(',');
            int X = 0, Y = 0;
            string Z = string.Empty;

            try
            {
                Z = Tamanhos.ToList().Where(T => T.ToUpper().Contains("X")).First();
                X = Convert.ToInt32(Z.Substring(Z.IndexOf("=") + 1));

                Z = Tamanhos.ToList().Where(T => T.ToUpper().Contains("Y")).First();
                Y = Convert.ToInt32(Z.Substring(Z.IndexOf("=") + 1));
            }
            catch { }

            return new System.Drawing.Point(X, Y);
        }

        /// <summary>
        /// Get e Set Ultimo Usuário a logar no sistema
        /// </summary>
        public static string UltimoUsuarioLogado
        {
            get
            {
                return RetornaConfig("UltimoLogon","");
            }
            set
            {
                GravaConfig("UltimoLogon", value);
            }
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}