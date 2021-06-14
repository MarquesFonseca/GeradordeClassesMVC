using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using DTO;
using BLL;

/// <summary>
/// Classe Controller gerada automática: TabelaTeste
/// Criador: MARQUES
/// Criada em 14/06/2021 às 18:07
/// </summary>
namespace BancoTeste.Controllers
{
      [Authorize]
      public class TabelaTesteController : Controller
      {
            //VwTabelaTesteBO<TabVwTabelaTeste> VwTabelatesteBO = new VwTabelaTesteBO<TabVwTabelaTeste>();
            TabelaTesteBO<TabTabelaTeste> TabelatesteBO = new TabelaTesteBO<TabTabelaTeste>();

      // GET: TabelaTeste
      public ActionResult Index()
      {
            //IEnumerable<TabVwTabelaTeste> listaRetornada = VwTabelatesteBO.FindAllLista().AsEnumerable<TabVwTabelaTeste>().OrderByDescending(M => M.DataCadastro);
            IEnumerable<TabTabelaTeste> listaRetornada = TabelatesteBO.FindAllLista().AsEnumerable<TabTabelaTeste>().OrderByDescending(M => M.DataCadastro);
            return View(listaRetornada);
      }

      // GET: TabelaTeste/Details/5
      public ActionResult Details(int id)
      {
            //List<TabVwTabelaTeste> listaRetornada = VwTabelatesteBO.FindAllLista(string.Format("Codigo = '{0}'", id)).ToList();
            List<TabTabelaTeste> listaRetornada = TabelatesteBO.FindAllLista(string.Format("Codigo = '{0}'", id)).ToList();

            if (listaRetornada.Count() > 0)
            {
                return View(listaRetornada[0]);
            }
            else
            {
                //Não retornou nenhum registro
                return RedirectToAction("Index");
            }
      }

      // GET: TabelaTeste/Create
      public ActionResult Create()
      {
            return View();
      }

      // POST: TabelaTeste/Create
      [HttpPost]
      public ActionResult Create(TabTabelaTeste tab)
      {
                try
                {
                    #region Validações e regras específicas para essa operação
                    //if (string.IsNullOrEmpty(Convert.ToString(tab.Descricao)))
                    //{
                    //    ModelState.AddModelError("Descricao", "Informe uma descrição!");
                    //}
                    #endregion
                    
                    if (!ModelState.IsValid)
                        return Create();

            tab.Codigo = Guid.NewGuid();

                    #region modelo anterior
                  //TabTabelaTeste tabelateste = new TabTabelaTeste();
                  //tabelateste.Codigo = Convert.ToInt32(tab.Codigo);
                  //tabelateste.Descricao = Convert.ToString(tab.Descricao);
                  //tabelateste.CampoUm = Convert.ToString(tab.CampoUm);
                  //tabelateste.CampoDois = Convert.ToString(tab.CampoDois);
                  //tabelateste.CampoTres = Convert.ToString(tab.CampoTres);
                  //tabelateste.CampoQuatro = Convert.ToString(tab.CampoQuatro);
                  //tabelateste.CampoBool = Convert.ToBoolean(tab.CampoBool.ToString().Split(',')[0]);
                  //tabelateste.CampoData = Convert.ToDateTime(tab.CampoData);
                    #endregion

                          int retorno = TabelatesteBO.Insert(tab);
                          if (retorno == 1)
                              return RedirectToAction("Details", new { id = tab.Codigo });
                          else
                              {
                                 //Ocorreu algum erro.....
                                 ModelState.AddModelError("", "Ocorreu algum erro no procedimento atual. Se o problema persistir procure o administrador do sistema.");
                                 return Create();
                              }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return Create();
                }
            }

      // GET: TabelaTeste/Edit/5
      public ActionResult Edit(string id)
      {
            List<TabTabelaTeste> listaRetornada = TabelatesteBO.FindAllLista(string.Format("Codigo = '{0}'", id)).ToList();

            if (listaRetornada.Count() > 0)
            {
                return View(listaRetornada[0]);
            }
            else
            {
                //Não retornou nenhum registro
                return RedirectToAction("Index");
            }
      }

      // POST: TabelaTeste/Edit/5
      [HttpPost]
      public ActionResult Edit(int id, TabTabelaTeste tab)
      {
                try
                {
                    #region Validações e regras específicas para essa operação
                    //if (string.IsNullOrEmpty(Convert.ToString(tab.Descricao)))
                    //{
                    //    ModelState.AddModelError("Descricao", "Informe uma descrição!");
                    //}
                    #endregion
                    
                    if (!ModelState.IsValid)
                        return Edit(id);

tab.Codigo = new Guid(id);
#region modelo anterior
                  //TabTabelaTeste tabelateste = new TabTabelaTeste();
                  //tabelateste.Codigo = Convert.ToInt32(tab.Codigo);
                  //tabelateste.Descricao = Convert.ToString(tab.Descricao);
                  //tabelateste.CampoUm = Convert.ToString(tab.CampoUm);
                  //tabelateste.CampoDois = Convert.ToString(tab.CampoDois);
                  //tabelateste.CampoTres = Convert.ToString(tab.CampoTres);
                  //tabelateste.CampoQuatro = Convert.ToString(tab.CampoQuatro);
                  //tabelateste.CampoBool = Convert.ToBoolean(tab.CampoBool.ToString().Split(',')[0]);
                  //tabelateste.CampoData = Convert.ToDateTime(tab.CampoData);
#endregion
                          int retorno = TabelatesteBO.Update(tab);
                          if (retorno == 1)
                              return RedirectToAction("Details", new { id = tab.Codigo });
                          else
                              {
                              //Ocorreu algum erro.....
                              ModelState.AddModelError("", "Ocorreu algum erro no procedimento atual. Se o problema persistir procure o administrador do sistema.");
                              return Edit(id);
                              }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return Edit(id);
                }
      }

      // GET: TabelaTeste/Delete/5
      public ActionResult Delete(int id)
      {
            try
            {
                  List<TabTabelaTeste> listaRetornada = this.TabelatesteBO.FindAllLista(string.Format("Codigo = '{0}'", id)).Take(1).ToList();

                  if (listaRetornada.Count > 0)
                  {
                        int retorno = this.TabelatesteBO.Delete(listaRetornada[0]);
                        if (retorno == 0)
                        {
                              //Ocorreu algum erro.....
                              return RedirectToAction("Index");
                        }
                  }
                  //Não retornou nenhum registro
                  return RedirectToAction("Index");
            }
            catch
            {
                  return RedirectToAction("Index");
            }
      }

      }
}
