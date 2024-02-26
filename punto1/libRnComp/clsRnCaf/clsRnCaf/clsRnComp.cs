using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libRnCaf
{
    public class clsRnComp
    {
        private int intDia;
        private float fltVrUnit;
        private int intCantLbrs;
        private bool boolCantLbrsQuinc;
        private bool boolCantLbrsFest;
        private string strError;

        public clsRnComp()
        {
                intDia = 0;
                fltVrUnit = 0;
                intCantLbrs = 0;
                boolCantLbrsQuinc = false;
                boolCantLbrsFest = false;
                strError = string.Empty;
        }

        public int Dia { set { intDia = value; } }
        public float VrUnid { get{ return fltVrUnit; } }
        public int CantLbrs { get {  return intCantLbrs; } }
        public bool CantQuinc{ get { return boolCantLbrsQuinc; } }
        public bool CantFest { get { return boolCantLbrsFest; } }

        private bool leerArchivo()
        {
            try
            {
                string strPath = AppDomain.CurrentDomain.BaseDirectory + @"pedido.txt";
                int intCantRg = 0, intDiaSem, intCantNorm, intCantQuinc, intCantFest;//archivos planos
                string strLinea;//capturar  llinea a linea el archivo plano
                string[] vectorLinea;//vector tipo cadena dinamico va hacer el split del archivo plano
                intCantRg = File.ReadAllLines(strPath).Length;//validar si hay registro en el txt
                if (intCantRg <= 0)
                    return true;
                StreamReader Archivo = new StreamReader(@strPath); //Objeto para leer el archivo 
                while ((strLinea = Archivo.ReadLine()) != null)  //Leer línea * línea el archivo 
                {                    
                    vectorLinea = strLinea.Split('|');
                    intDiaSem = Convert.ToInt32(vectorLinea[0]);
                    intCantNorm = Convert.ToInt32(vectorLinea[2]);
                    intCantQuinc = Convert.ToInt32(vectorLinea[3]);
                    intCantFest= Convert.ToInt32(vectorLinea[4]);  //Promedio de descuento
                    if (intDia == intDiaSem)
                    {
                        intCantLbrs = intCantNorm;
                        if (boolCantLbrsQuinc)
                        {
                            intCantLbrs += intCantQuinc;
                        }
                        if (boolCantLbrsFest)
                        {
                            intCantLbrs += intCantFest;
                        }
                           //Porcentaje del descuento
                        break;
                    }
                    //son los privados  intcod,intcant
                }
                Archivo.Close();
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
    }
}
