using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using INMUEBLES.Entidades;
using INMUEBLES.Dao;

namespace INMUEBLES.Negocio
{
    public class FotoN
    {
        FotoDAO fotoDAO = new FotoDAO();

        public List<FotoE> ListadoFotos()
        {
            return fotoDAO.ListadoFotos();
        }
        public bool AgregarFoto(FotoE fotoE)
        {
            return fotoDAO.AgregarFoto(fotoE);
        }
        public List<FotoE> ListarURL_Foto(int idInmueble)
        {
            return fotoDAO.ListarURL_Foto(idInmueble);
        }
        public int CantidadDeFotosXinmueble(int idInmueble)
        {
            return fotoDAO.CantidadDeFotosXinmueble(idInmueble);
        }
    }
}
