using System;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ScapeRoomProject
{
    public sealed class Session
    {
        private static volatile Session instance;
        private static object sync = new Object();

        private Session()
        { }

        public static Session Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (sync)
                    {
                        if (instance == null)
                        {
                            instance = new Session();
                        }
                    }
                }
                return instance;
            }
        }

        public String getSenha(int modulo)
        {
            switch (modulo)
            {
                case 1: //FACIL
                    return "c";
                case 2: //MEDIO
                    return "~qvs";
                case 3: //MEDIO
                    return "~pvqvs";
                case 4: // FACIL
                    return "p^q";
                case 5: // DIFICIL
                    return "(pv~qvr)^(~pvq)";
                case 6: // DIFICIL
                    return "~p";
                case 7: //DIFICIL
                    return "pv~qvr";
                case 8: //MEDIO
                    return "qvs";
                case 9: //DIFICIL
                    return "u";
                case 10: //MEDIO
                    return "~pvq";
                case 11: //FACIL
                    return "p^~q";
                case 12: //SEQUESTRADOR
                    return "Bruno Campagnolo";
                default:
                    return "Erro";
            }
        }

        public String getResposta(int modulo)
        {
            switch (modulo)
            {
                case 1: //SEM RESPOSTA
                    return ""; 
                case 2:
                    return "resposta2";
                case 3:
                    return "resposta3";
                case 4:
                    return "resposta4";
                case 5:
                    return "resposta5";
                case 6:
                    return "resposta6";
                case 7: //SEM RESPOSTA
                    return "";
                case 8:
                    return "resposta8";
                case 9:
                    return "resposta9";
                case 10: //SEM RESPOSTA
                    return "";
                case 11:
                    return "resposta11";
                case 12:
                    return "resposta12";
                default:
                    return "";
            }
        }
    }
}

