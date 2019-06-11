using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dal
{
    public class EmpresaDal
    {
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
