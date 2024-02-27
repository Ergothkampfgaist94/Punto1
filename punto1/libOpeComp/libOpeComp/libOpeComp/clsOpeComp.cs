using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using libRnCaf;

namespace libOpeComp
{
    public class clsOpeComp
    {
        private int indDia;
        private int intCant;
        private int intCantQuinc;
        private int intCantFest;
        private float fltVrPagar;
        private string strError;

        public clsOpeComp()
        {
        int intdDia = 0;
        int intCant = 0;
            int intCantQuinc = 0;
            int intlCantFest = 0;
        float fltVrPagar= 0;
        string strError= string.Empty;
        }

        public int Día{set{ indDia = value; } }
        public int Quincena { set { intCantQuinc = value; } }
        public int Festivo { set { intCantFest = value;} }
        public float CantApagar { get { return fltVrPagar; } }
        public int Cantidad { get { return intCant; } }

        public bool Facturar() {

            try
            {
                clsRnComp objRn = new clsRnComp();
                
                objRn.Dia = indDia;
                objRn.CantQuinc = intCantQuinc;
                objRn.CantFest = intCantFest;
                fltVrPagar = objRn.CantLbrs * objRn.VrUnid;

                if (!objRn.ExecuteRead())
                {
                    strError = objRn.Error;
                    return false;
                }
               
            }
            catch (Exception ex)
            {

                strError = ex.Message;
                return false;
            }
            return true;
        }

    }
    
}
