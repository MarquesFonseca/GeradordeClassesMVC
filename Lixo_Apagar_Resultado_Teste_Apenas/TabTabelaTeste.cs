using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DTO
{
      /// <summary>
      /// Classe DTO gerada automática: TabTabelaTeste
      /// Criador: MARQUES
      /// Criada em 14/06/2021 às 18:07
      /// </summary>
      public class TabTabelaTeste
      {
            // Atributos
            private int _Codigo;
            private string _Descricao;
            private string _CampoUm;
            private string _CampoDois;
            private string _CampoTres;
            private string _CampoQuatro;
            private bool _CampoBool;
            private DateTime? _CampoData;

            // Propriedades
            #region Codigo
            [Required(ErrorMessage = "Informe o campo Codigo")]
            [Display(Name = "Codigo")]
            public int Codigo{get { return _Codigo; }set { _Codigo = value; } }
            #endregion

            #region Descricao
            //[Required(ErrorMessage = "Informe o campo Descricao")]
            [Display(Name = "Descricao")]
            public string Descricao{get { return _Descricao; }set { _Descricao = value; } }
            #endregion

            #region CampoUm
            //[Required(ErrorMessage = "Informe o campo CampoUm")]
            [Display(Name = "CampoUm")]
            public string CampoUm{get { return _CampoUm; }set { _CampoUm = value; } }
            #endregion

            #region CampoDois
            //[Required(ErrorMessage = "Informe o campo CampoDois")]
            [Display(Name = "CampoDois")]
            public string CampoDois{get { return _CampoDois; }set { _CampoDois = value; } }
            #endregion

            #region CampoTres
            //[Required(ErrorMessage = "Informe o campo CampoTres")]
            [Display(Name = "CampoTres")]
            public string CampoTres{get { return _CampoTres; }set { _CampoTres = value; } }
            #endregion

            #region CampoQuatro
            //[Required(ErrorMessage = "Informe o campo CampoQuatro")]
            [Display(Name = "CampoQuatro")]
            public string CampoQuatro{get { return _CampoQuatro; }set { _CampoQuatro = value; } }
            #endregion

            #region CampoBool
            //[Required(ErrorMessage = "Informe o campo CampoBool")]
            [Display(Name = "CampoBool")]
            public bool CampoBool{get { return _CampoBool; }set { _CampoBool = value; } }
            #endregion

            #region CampoData
            //[Required(ErrorMessage = "Informe o campo CampoData")]
            [Display(Name = "CampoData")]
            public DateTime? CampoData{get { return _CampoData; }set { _CampoData = value; } }
            #endregion

      }
}
