using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using INMUEBLES.Entidades;
using INMUEBLES.Dao;

namespace INMUEBLES.Negocio
{
    public class PropietarioN
    {
        PropietarioDAO propietarioDAO = new PropietarioDAO();

        public List<PropietarioE> ListaPropietario()
        {
            return propietarioDAO.ListaPropietario();
        }
        public bool AgregarPropietario(PropietarioE propietarioE)
        {
            return propietarioDAO.AgregarPropietario(propietarioE);
        }
        public int BuscarIDPropietarioXidInmueble(int idInmueble)
        {
            return propietarioDAO.BuscarIDPropietarioXidInmueble(idInmueble);
        }
    }
}
