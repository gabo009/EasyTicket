using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Crud
{
    public class EmpresaCrud
    {
        public bool AgregarEmpresa(Entidad.EmpresaEnt empresaEnt)
        {
            Repositorio.Dal.EmpresaDal dal = new Repositorio.Dal.EmpresaDal();
            return dal.AgregarEmpresa(empresaEnt);
        }
        public Entidad.EmpresaEnt BuscarEmpresa(int id_empresa)
        {
            Repositorio.Dal.EmpresaDal dal = new Repositorio.Dal.EmpresaDal();
            return dal.BuscarEmpresa(id_empresa);
        }
        public Entidad.EmpresaEnt ModificarEmpresa(Entidad.EmpresaEnt empresaEnt)
        {
            Repositorio.Dal.EmpresaDal dal = new Repositorio.Dal.EmpresaDal();
            return dal.ModificarEmpresa(empresaEnt);
        }
        public List<Entidad.EmpresaEnt> ListarEmpresa()
        {
            Repositorio.Dal.EmpresaDal dal = new Repositorio.Dal.EmpresaDal();
            return dal.ListarEmpresas();
        }
        public bool EliminarEmpresa(int id_empresa)
        {
            Repositorio.Dal.EmpresaDal dal = new Repositorio.Dal.EmpresaDal();
            return dal.EliminarEmpesa(id_empresa);
        }
    }
}
