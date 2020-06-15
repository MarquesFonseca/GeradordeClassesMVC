using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace GeradorClasses
{
    /// <summary>
    /// Atributos para mapear o banco
    /// Data de implementação: 15/05/2012
    /// Desenvolvedor: Marcos Levy
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class Atributos : System.Attribute
    {
        private string _tipo;
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private string _descricaoCampo;
        public string DescricaoCampo
        {
            get { return _descricaoCampo; }
            set { _descricaoCampo = value; }
        }

        private bool _chavePrimaria;
        public bool ChavePrimaria
        {
            get { return _chavePrimaria; }
            set { _chavePrimaria = value; }
        }

        private bool _chaveEstrangeira;
        public bool ChaveEstrangeira
        {
            get { return _chaveEstrangeira; }
            set { _chaveEstrangeira = value; }
        }

        private string _classeChaveEstrangeira;
        public string ClasseChaveEstrangeira
        {
            get { return _classeChaveEstrangeira; }
            set { _classeChaveEstrangeira = value; }
        }

        private int _tamanhoCampo;
        public int TamanhoCampo
        {
            get { return _tamanhoCampo; }
            set { _tamanhoCampo = value; }
        }

        private bool _aceitaNulo;
        public bool AceitaNulo
        {
            get { return _aceitaNulo; }
            set { _aceitaNulo = value; }
        }

        private bool _autoIncremento;
        public bool AutoIncremento
        {
            get { return _autoIncremento; }
            set { _autoIncremento = value; }
        }

        private bool _exibirNaGrid;
        public bool ExibirNaGrid
        {
            get { return _exibirNaGrid; }
            set { _exibirNaGrid = value; }
        }

        private string _descricaoExibirChaveEstrangeira;
        public string DescricaoExibirChaveEstrangeira
        {
            get { return _descricaoExibirChaveEstrangeira; }
            set { _descricaoExibirChaveEstrangeira = value; }
        }

        /// <summary>
        /// atributo criado para ser relacionado a chave estrangeira no bidingSource AddLista. 
        /// </summary>
        private bool _relacionarChaveEstrangeiraNovoCadastro;
        public bool RelacionarChaveEstrangeiraNovoCadastro
        {
            get { return _relacionarChaveEstrangeiraNovoCadastro; }
            set { _relacionarChaveEstrangeiraNovoCadastro = value; }
        }

        /// <summary>
        /// Caso o campo seja chave estrangeira este atributo define se o mesmo sera mostrado no GridView. 
        /// </summary>
        private bool _exibirNaGridDescricaoChaveEstrangeira;
        public bool ExibirNaGridDescricaoChaveEstrangeira
        {
            get { return _exibirNaGridDescricaoChaveEstrangeira; }
            set { _exibirNaGridDescricaoChaveEstrangeira = value; }
        }

        private bool _alinharDireita;
        public bool AlinharDireita
        {
            get { return _alinharDireita; }
            set { _alinharDireita = value; }
        }
    }
}
