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
        private int intCantLbrsQuinc;
        private int intCantLbrsFest;
        private string error;

        public clsRnComp()
        {
                intDia = 0;
                fltVrUnit = 0;
                intCantLbrs = 0;
                intCantLbrsQuinc = 0;
                intCantLbrsFest = 0;
                error = string.Empty;                
        }

        public int Dia { set { intDia = value; } }
        public float VrUnid { get{ return fltVrUnit; } }
        public int CantLbrs { get {  return intCantLbrs; } }
        public int CantQuinc { set { intCantLbrsQuinc = value; } }
        public int CantFest { set { intCantLbrsFest = value; } }
        public string Error { get { return error; } }   

        private bool leerArchivo()
        {
            try
            {
                string strPath = AppDomain.CurrentDomain.BaseDirectory + @"pedido.txt";
                int intCantRg = 0, intDiaSem,intCantNorm, intCantQuinc, intCantFest;//archivos planos
                float fltVrUnit;
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
                    fltVrUnit = Convert.ToSingle(vectorLinea[1]);
                    intCantNorm = Convert.ToInt32(vectorLinea[2]);
                    intCantQuinc = Convert.ToInt32(vectorLinea[3]);
                    intCantFest= Convert.ToInt32(vectorLinea[4]);  //Promedio de descuento
                    if (intDia == intDiaSem)
                    {
                        intCantLbrs = intCantNorm;
                        if (intCantQuinc > 0)
                        {
                            intCantLbrs += intCantQuinc;
                        }
                        if (intCantLbrsFest>0)
                        {
                            intCantLbrs += intCantFest;
                        }
                        break;
                    }
                }
                Archivo.Close();
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
        public bool ExecuteRead() {
            return leerArchivo();
        }
    }
}
