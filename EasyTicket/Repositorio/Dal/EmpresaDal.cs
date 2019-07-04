using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dal
{
    /// <summary>
    /// Capa de acceso de la base de datos de Empresa (Dal)
    /// </summary>
    public class EmpresaDal
    {
        /// <summary>
        /// Método para agregar una empresa en la BD
        /// </summary>
        /// <param name="empresaEnt">Objeto de la clase EmpresaEnt</param>
        /// <returns>retorna un verdadero o un falso en caso de exception para guardar el obj en la BD</returns>
        public bool AgregarEmpresa(Entidad.EmpresaEnt empresaEnt)
        {
            db_Entities db = new db_Entities();
            try
            {
                empresa empresa = new empresa
                {
                    id_empresa = empresaEnt.id_empresa,
                    nom_empresa = empresaEnt.nom_empresa,
                    rut_empresa = empresaEnt.rut_empresa
                };
                db.Empresa.Add(empresa);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Método para buscar una empresa en la BD
        /// </summary>
        /// <param name="id_empresa">atributo del obj para buscar en la BD</param>
        /// <returns>retorna el obj, que buscas el la BD según el id_empresa</returns>
        public Entidad.EmpresaEnt BuscarEmpresa(int id_empresa)
        {
            db_Entities db = new db_Entities();
            Entidad.EmpresaEnt empresaEnt;
            empresa empresaRes = db.Empresa.FirstOrDefault(e => e.id_empresa == id_empresa);
            empresaEnt = new Entidad.EmpresaEnt
            {
                id_empresa = empresaRes.id_empresa,
                nom_empresa = empresaRes.nom_empresa,
                rut_empresa = empresaRes.rut_empresa
            };
            return empresaEnt;
        }
        /// <summary>
        /// Método para modificar un objeto de tipo Empresa
        /// </summary>
        /// <param name="empresaEnt">obj que trae de la BD</param>
        /// <returns>retorna un obj de tipo empresa o un nulo en caso de exception</returns>
        public Entidad.EmpresaEnt ModificarEmpresa(Entidad.EmpresaEnt empresaEnt)
        {
            db_Entities db = new db_Entities();
            try
            {
                empresa empresaRes = db.Empresa.FirstOrDefault(e => e.id_empresa == empresaEnt.id_empresa);

                empresaRes.id_empresa = empresaEnt.id_empresa;
                empresaRes.nom_empresa = empresaEnt.nom_empresa;
                empresaRes.rut_empresa = empresaEnt.rut_empresa;

                db.SaveChanges();

                return BuscarEmpresa(empresaRes.id_empresa);
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// Esto es para listar las empresas de la BD
        /// </summary>
        /// <returns>retorna las empresas que están en la BD, en caso de que no existan, retorna un nulo</returns>
        public List<Entidad.EmpresaEnt> ListarEmpresas()
        {
            db_Entities db = new db_Entities();
            List<Entidad.EmpresaEnt> listaEmpresas = new List<Entidad.EmpresaEnt>();
            Entidad.EmpresaEnt empresaEnt = new Entidad.EmpresaEnt();
            try
            {
                foreach (var e in db.Empresa.ToList())
                {
                    empresaEnt = new Entidad.EmpresaEnt
                    {
                        id_empresa = e.id_empresa,
                        nom_empresa = e.nom_empresa,
                        rut_empresa = e.rut_empresa
                    };

                    listaEmpresas.Add(empresaEnt);
                }
            }
            catch (Exception)
            {

                return null;
            }

            return listaEmpresas;
        }
        /// <summary>
        /// Método para eliminar una empresa
        /// </summary>
        /// <param name="id_empresa">por medio del id se buscará y eliminará la empresa</param>
        /// <returns>si se elimina una empresa enviara un verdadero, si no mandará un falso</returns>
        public bool EliminarEmpesa(int id_empresa)
        {
            db_Entities db = new db_Entities();
            try
            {
                empresa empresaRes = db.Empresa.FirstOrDefault(e => e.id_empresa == id_empresa);

                db.Empresa.Remove(empresaRes);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

