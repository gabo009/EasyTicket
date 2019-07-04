using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Crud
{
    /// <summary>
    /// Clase de Manejo de Datos de Empresa
    /// </summary>
    public class EmpresaCrud
    {
        /// <summary>
        /// Método del CRUD para agregar una empresa en la BD
        /// </summary>
        /// <param name="empresaEnt">Objeto de la clase EmpresaEnt</param>
        /// <returns>retorna un verdadero o un falso en caso de exception para guardar el obj en la BD</returns>
        public bool AgregarEmpresa(Entidad.EmpresaEnt empresaEnt)
        {
            Repositorio.Dal.EmpresaDal dal = new Repositorio.Dal.EmpresaDal();
            return dal.AgregarEmpresa(empresaEnt);
        }
        /// <summary>
        /// Método del CRUD para buscar una empresa en la BD
        /// </summary>
        /// <param name="id_empresa">atributo del obj para buscar en la BD</param>
        /// <returns>retorna el obj, que buscas el la BD según el id_empresa</returns>
        public Entidad.EmpresaEnt BuscarEmpresa(int id_empresa)
        {
            Repositorio.Dal.EmpresaDal dal = new Repositorio.Dal.EmpresaDal();
            return dal.BuscarEmpresa(id_empresa);
        }
        /// <summary>
        /// Método del CRUD para modificar un objeto del tipo Empresa
        /// </summary>
        /// <param name="empresaEnt">Objeto de la clase EmpresaEnt</param>
        /// <returns>retorna un obj de tipo EmpresaEnt o un nulo en caso de exception</returns>
        public Entidad.EmpresaEnt ModificarEmpresa(Entidad.EmpresaEnt empresaEnt)
        {
            Repositorio.Dal.EmpresaDal dal = new Repositorio.Dal.EmpresaDal();
            return dal.ModificarEmpresa(empresaEnt);
        }
        /// <summary>
        /// Esto es para listar las empresas de la BD
        /// </summary>
        /// <returns>retorna las empresas que están en la BD, en caso de que no existan, retorna un nulo</returns>
        public List<Entidad.EmpresaEnt> ListarEmpresa()
        {
            Repositorio.Dal.EmpresaDal dal = new Repositorio.Dal.EmpresaDal();
            return dal.ListarEmpresas();
        }
        /// <summary>
        /// Método del CRUD que buscara y eliminara una empresa de la BD
        /// </summary>
        /// <param name="id_empresa">argumento del tipo int que corresponde al id de la empresa</param>
        /// <returns>si se elimina una empresa enviara un verdadero, si no mandará un falso</returns>
        public bool EliminarEmpresa(int id_empresa)
        {
            Repositorio.Dal.EmpresaDal dal = new Repositorio.Dal.EmpresaDal();
            return dal.EliminarEmpesa(id_empresa);
        }
    }
}
